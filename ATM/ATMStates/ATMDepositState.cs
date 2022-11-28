using ATM.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ATMStates
{
    public class ATMDepositState : ATMBaseState
    {
        double total;

        public ATMDepositState(ATMForm atmForm) : base(atmForm)
        {
            LangSwitch.OnLangSwitch += () =>
            {
                atmForm.D_Title_L.Text =   LangSwitch.GetString("D");
                atmForm.D_Prompt_L.Text =  LangSwitch.GetString("D_P");
                atmForm.D_Back_L.Text =    LangSwitch.GetString("Misc_GB");
                atmForm.D_Confirm_L.Text = LangSwitch.GetString("Misc_C");
            };
        }

        public override void OnEnterState()
        {
            total = 0;
            atmForm.Deposit_P.Show();
            atmForm.Deposit_Amount_L.Text = "£0";
            atmForm.Deposit_Error.Text = "";

            AudioHandler.PlayAudio("deposit");
        }

        public override void OnExitState()
        {
            atmForm.Deposit_P.Hide();
        }

        public override void OnBClicked(int b)
        {
            switch (b)
            {
                case 3: atmForm.SwitchState(atmForm.ATMMainOptionsState); break;
                case 6: 
                    if(total == 0)
                    {
                        atmForm.Deposit_Error.Text = LangSwitch.GetString("V_0");
                        return;
                    }

                    atmForm.CashIO.TakeIn(total);
                    atmForm.ATMDepositResults.SetResults(total, atmForm.ATM.GetAccount().Balance);
                    atmForm.SwitchState(atmForm.ATMDepositResults);
                    break;
            }
        }

        public override void OnEnterClicked()
        {
            var inputbox = new InputBox("Cash Input Sim", "Cash to Insert:");
            inputbox.ShowDialog();
            var amount = inputbox.Input_TB.Text;
            var cash = double.Parse(amount);
            total += cash;
            atmForm.Deposit_Amount_L.Text = $"{LangSwitch.GetString("D_D")}{total}";
        }
    }
}
