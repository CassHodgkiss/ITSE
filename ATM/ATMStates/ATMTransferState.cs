using ATM.Forms;
using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ATMStates
{
    public class ATMTransferState : ATMBaseState
    {
        TransferState state;

        int index;
        int[] accountId;
        int[] money;

        AccountM transferTo;
        double amount;

        string Id
        {
            get
            {
                string id = "";
                for (int i = 0; i < index; i++)
                    id += accountId[i];
                for (int i = index; i < 6; i++)
                    id += "x";
                    
                return id;
            }
        }

        int Amount
        {
            get
            {
                switch (index)
                {
                    case 1: return money[0];
                    case 2: return (10 * money[0]) + money[1];
                    case 3: return (100 * money[0]) + (10 * money[1]) + money[2];
                    default: return 0;
                }
            }
        }

        public ATMTransferState(ATMForm atmForm) : base(atmForm)
        {
            LangSwitch.OnLangSwitch += () =>
            {
                atmForm.T_Title_M_L.Text =   LangSwitch.GetString("T");
                atmForm.T_Prompt_M_L.Text =  LangSwitch.GetString("T_M");
                atmForm.T_Title_I_L.Text =   LangSwitch.GetString("T");
                atmForm.T_Prompt_I_L.Text =  LangSwitch.GetString("T_AN");
                atmForm.T_Back_M_L.Text =    LangSwitch.GetString("Misc_GB");
                atmForm.T_Back_I_L.Text =    LangSwitch.GetString("Misc_GB");
                atmForm.T_Confirm_M_L.Text = LangSwitch.GetString("Misc_C");
                atmForm.T_Confirm_I_L.Text = LangSwitch.GetString("Misc_C");
            };
        }

        public override void OnEnterState()
        {
            Reset();
            state = TransferState.Id;
            atmForm.T_Error_M_L.Text = "";
            atmForm.T_Error_Id_L.Text = "";
            atmForm.T_Id_L.Text = "xxxxxx";
            atmForm.T_M_L.Text = "£0";
            atmForm.Transfer_AccountId_P.Show();
        }

        public override void OnExitState()
        {
            atmForm.Transfer_AccountId_P.Hide();
            atmForm.Transfer_Money_P.Hide();
            Reset();
            atmForm.T_Id_L.Text = "";
        }

        public override void OnNClicked(int n)
        {
            AddNum(n);
        }

        public override void OnEnterClicked()
        {
            if(state == TransferState.Id)
                Next();   
            else
                Transfer();
        }

        public override void OnBackSpaceClicked()
        {
            if (index == 0) return;
            index--;

            if (state == TransferState.Id)
            {
                accountId[index] = 0;
                atmForm.T_Id_L.Text = Id;
            }
            else
            {
                money[index] = 0;
                atmForm.T_M_L.Text = "£" + Amount;
            }      
        }

        public override void OnBClicked(int b)
        {
            switch (b)
            {
                case 3: atmForm.SwitchState(atmForm.ATMMainOptionsState); break;
                case 6: Next(); break;
            }
        }

        void Next()
        {
            if (state == TransferState.Id)
            {
                if (index != 6) return;

                transferTo = atmForm.Accounts.SearchByAccountId(int.Parse(Id));

                if (transferTo == null)
                {
                    atmForm.T_Error_Id_L.Text = LangSwitch.GetString("T_NF");
                    return;
                }
                if (transferTo.Id == atmForm.ATM.GetAccount().Id)
                {
                    atmForm.T_Error_Id_L.Text = LangSwitch.GetString("T_SA");
                    return;
                }

                atmForm.T_Error_M_L.Text = "";
                atmForm.Transfer_AccountId_P.Hide();
                atmForm.Transfer_Money_P.Show();
                index = 0;
                state = TransferState.Money;
            }
            else
                Transfer();
        }

        void Transfer()
        {
            amount = Amount;

            if (amount == 0)
            {
                atmForm.T_Error_M_L.Text = LangSwitch.GetString("V_0");
                return;
            }

            if (atmForm.ATM.VerifyIf2FATransfer())
            {
                atmForm.ATM2FAState.SetReturnFunctions(Passed2FA, Failed2FA);
                atmForm.SwitchState(atmForm.ATM2FAState);
            }
            else
                TransferPassed();
        }

        void TransferPassed()
        {      
            double max = atmForm.ATM.GetMaxWithdraw();

            if (max < amount) 
            {
                if (max > 0) atmForm.ATM.Transfer(transferTo, max);
                atmForm.ATMTransferResultsState.SetResults(transferTo.Id_String, amount, atmForm.ATM.GetAccount().Balance, true, max);        
            }
            else
            {
                atmForm.ATM.Transfer(transferTo, amount);
                atmForm.ATMTransferResultsState.SetResults(transferTo.Id_String, amount, atmForm.ATM.GetAccount().Balance, false);
            }
            

            atmForm.SwitchState(atmForm.ATMTransferResultsState);
        }

        void Passed2FA()
        {
            TransferPassed();
        }

        void Failed2FA()
        {
            atmForm.SwitchState(atmForm.ATMTransfer2FAFailedState);
        }

        void AddNum(int num)
        {
            if(state == TransferState.Id)
            {
                if (index == 6) return;

                accountId[index] = num;
                index++;
                atmForm.T_Id_L.Text = Id;
            }
            else
            {
                if (index == 3) return;
                if (index == 0 && num == 0) return;

                money[index] = num;
                index++;
                atmForm.T_M_L.Text = "£" + Amount;
            }
        }

        void Reset()
        {
            index = 0;
            accountId = new int[6];
            money = new int[3];
        }

    }

    enum TransferState
    {
        Id,
        Money
    }
}
