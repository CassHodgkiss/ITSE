using ATM.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ATMStates
{
    public class ATMWithdrawAmountState : ATMBaseState
    {
        int[] amount;
        int amountIndex;
        int Amount 
        {
            get
            {
                switch (amountIndex)
                {
                    case 1: return amount[0];
                    case 2: return (10 * amount[0]) + amount[1];
                    case 3: return (100 * amount[0]) + (10 * amount[1]) + amount[2];
                    default: return 0;
                }
            }
        }

        public ATMWithdrawAmountState(ATMForm atmForm) : base(atmForm)
        {
            amountIndex = 0;
            amount = new int[3];

            LangSwitch.OnLangSwitch += () =>
            {
                atmForm.WI_Prompt_L.Text =  LangSwitch.GetString("W_IWA");
                atmForm.WI_Back_L.Text =    LangSwitch.GetString("Misc_GB");
                atmForm.WI_Confirm_L.Text = LangSwitch.GetString("Misc_C");
            };
        }

        public override void OnEnterState()
        {
            atmForm.WI_Error_L.Text = "";
            amountIndex = 0;
            amount = new int[3];
            DisplayAmount();
            atmForm.InputWithdrawAmount_P.Show();

            AudioHandler.PlayAudio("withdraw_amount");
        }

        public override void OnExitState()
        {
            atmForm.InputWithdrawAmount_P.Hide();
        }

        public override void OnBClicked(int b)
        {
            switch (b)
            {
                case 3: GoBack(); break;
                case 6: Withdraw(); break;
            }
        }

        public override void OnEnterClicked()
        {
            Withdraw();
        }

        void Withdraw()
        {
            int value = Amount;

            if (value == 0)
            {
                atmForm.WI_Error_L.Text = LangSwitch.GetString("V_0");
                AudioHandler.PlayAudio("withdraw_0");
                return;
            }

            atmForm.ATMWithdrawState.Withdraw(value);
        }

        public override void OnNClicked(int n)
        {
            if (amountIndex == 3) return;
            if(amountIndex == 0 && n == 0) return;

            amount[amountIndex] = n;
            amountIndex++;
            DisplayAmount();
        }

        public override void OnBackSpaceClicked()
        {
            if (amountIndex == 0) return;
            amountIndex--;
            amount[amountIndex] = 0;
            DisplayAmount();
        }

        void DisplayAmount()
        {
            atmForm.WI_Amount_L.Text = LangSwitch.GetString("W_W") + Amount;
        }

        void GoBack()
        {
            atmForm.SwitchState(atmForm.ATMWithdrawState);
        }
    }
}