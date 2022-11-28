using ATM.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ATMStates
{
    public class ATMWithdrawState : ATMBaseState
    {
        double withdrawValue;

        public ATMWithdrawState(ATMForm atmForm) : base(atmForm)
        {
            LangSwitch.OnLangSwitch += () =>
            {
                atmForm.W_InputAmount_L.Text = LangSwitch.GetString("T_IA");
                atmForm.W_Back_L.Text =        LangSwitch.GetString("Misc_GB");
            };
        }

        public override void OnEnterState()
        {
            atmForm.Withdraw_P.Show();

            AudioHandler.PlayAudio("withdraw");
        }

        public override void OnExitState()
        {
            atmForm.Withdraw_P.Hide();
        }

        public override void OnBClicked(int b)
        {
            switch (b)
            {
                case 1: Withdraw(10); break;
                case 2: Withdraw(20); break;
                case 4: Withdraw(50); break;
                case 5: Withdraw(100); break;
                case 6: InputAmount(); break;
                case 3: GoBack(); break;
            }
        }

        public void Withdraw(double value)
        {
            withdrawValue = value;

            if (atmForm.ATM.VerifyIf2FAWithdraw())
            {
                atmForm.ATM2FAState.SetReturnFunctions(Passed2FA, Failed2FA);
                atmForm.SwitchState(atmForm.ATM2FAState);
            }
            else WithdrawPassed();
        }

        void WithdrawPassed()
        {
            double max = atmForm.ATM.GetMaxWithdraw();

            if (max < withdrawValue)
            {
                if (max > 0) atmForm.ATM.Withdraw(max);
                atmForm.ATMWithdrawResultsState.SetResults(withdrawValue, atmForm.ATM.GetAccount().Balance, true, max);
            }
            else
            {
                atmForm.ATM.Withdraw(withdrawValue);
                atmForm.ATMWithdrawResultsState.SetResults(withdrawValue, atmForm.ATM.GetAccount().Balance, false);
            }

            atmForm.SwitchState(atmForm.ATMWithdrawResultsState);
        }

        void InputAmount()
        {
            atmForm.SwitchState(atmForm.ATMInputWithdrawAmountState);
        }

        void GoBack()
        {
            atmForm.SwitchState(atmForm.ATMMainOptionsState);
        }

        void Passed2FA()
        {
            WithdrawPassed();
        }

        void Failed2FA()
        {
            atmForm.SwitchState(atmForm.ATMWithdraw2FAFailedState);
        }
    }
}
