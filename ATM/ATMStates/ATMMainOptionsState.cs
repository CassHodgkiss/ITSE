using ATM.Forms;
using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ATMStates
{
    public class ATMMainOptionsState : ATMBaseState
    {
        bool IsLTD = false;

        public ATMMainOptionsState(ATMForm atmForm) : base(atmForm)
        {
            LangSwitch.OnLangSwitch += () =>
            {
                atmForm.ViewAccount_L.Text =   LangSwitch.GetString("MO_VA");
                atmForm.Withdraw_L.Text =      LangSwitch.GetString("MO_W");
                atmForm.Transfer_L.Text =      LangSwitch.GetString("T");
                atmForm.ViewStatement_L.Text = LangSwitch.GetString("MO_VS");
                atmForm.Deposit_L.Text =       LangSwitch.GetString("D");
                atmForm.EjectCard_L.Text =     LangSwitch.GetString("MO_EC");
            };
        }

        public override void OnEnterState()
        {
            IsLTD = atmForm.ATM.GetAccount() is LongTermDepositM;

            if (IsLTD)
            {
                atmForm.Withdraw_L.BackColor = Color.Gray;
                atmForm.Transfer_L.BackColor = Color.Gray;
            }
            else
            {
                atmForm.Withdraw_L.BackColor = Color.FromArgb(255, 227, 227, 227);
                atmForm.Transfer_L.BackColor = Color.FromArgb(255, 227, 227, 227);
            }

            atmForm.MainOptions_P.Show();

            AudioHandler.PlayAudio("main_options");
        }

        public override void OnExitState()
        {
            atmForm.MainOptions_P.Hide();
        }

        public override void OnBClicked(int b)
        {
            switch (b)
            {
                case 1: ViewAccount();   break;
                case 2: Withdraw();      break;
                case 3: Transfer();      break;
                case 4: ViewStatement(); break;
                case 5: Deposit();       break;
                case 6: EjectCard();     break;
            }
        }

        void ViewAccount()
        {
            atmForm.SwitchState(atmForm.ATMViewAccountState);
        }

        void Withdraw()
        {
            if(!IsLTD)
                atmForm.SwitchState(atmForm.ATMWithdrawState);
        }

        void Deposit()
        {
            atmForm.SwitchState(atmForm.ATMDepositState);
        }

        void Transfer()
        {
            if (!IsLTD)
                atmForm.SwitchState(atmForm.ATMTransferState);
        }

        void ViewStatement()
        {
            atmForm.SwitchState(atmForm.ATMViewStatementState);
        }

        void EjectCard()
        {
            AudioHandler.PlayAudio("ejecting_card");
            atmForm.ATM.Logout();
            atmForm.SwitchState(atmForm.ATMWaitingForCardState);
        }
    }
}
