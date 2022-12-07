using ATM.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ATMStates
{
    public class ATMWithdrawResultsState : ATMBaseState
    {
        public ATMWithdrawResultsState(ATMForm atmForm) : base(atmForm)
        {
            LangSwitch.OnLangSwitch += () =>
            {
                atmForm.WR_Back_L.Text = LangSwitch.GetString("Misc_GB");
            };
        }

        public override void OnEnterState()
        {
            atmForm.WithdrawResults_P.Show();
        }

        public override void OnExitState()
        {
            atmForm.WithdrawResults_P.Hide();
        }

        public void SetResults(double withdrew, double balance, bool isOverMax, double max = 0)
        {
            if (isOverMax)
            {
                if (max == 0)
                {
                    atmForm.WR_Prompt_L.Text = LangSwitch.GetString("WR_NS");
                    atmForm.WR_Withdrew_L.Text = "";
                    atmForm.WR_NewBal_L.Text = "";
                    atmForm.WR_Error_L.Text = LangSwitch.GetString("WR_ALR");
                    atmForm.WR_Collect_L.Text = "";
                    AudioHandler.PlayAudio("withdraw_failed");
                    return;
                }

                atmForm.WR_Withdrew_L.Text = $"{LangSwitch.GetString("WR_W1")}{max.ToString("0.##")}";
                atmForm.WR_NewBal_L.Text = $"{LangSwitch.GetString("R_NB")}{balance.ToString("0.##")}";
                atmForm.WR_Error_L.Text = $"{LangSwitch.GetString("WR_OW1")}{max.ToString("0.##")} {LangSwitch.GetString("WR_OW2")}{withdrew.ToString("0.##")} {LangSwitch.GetString("WR_ALR")}";
            }
            else
            {
                atmForm.WR_Withdrew_L.Text = $"{LangSwitch.GetString("WR_W1")}{withdrew.ToString("0.##")}";
                atmForm.WR_NewBal_L.Text = $"{LangSwitch.GetString("R_NB")}{balance.ToString("0.##")}";
                atmForm.WR_Error_L.Text = "";
            }

            atmForm.WR_Prompt_L.Text = LangSwitch.GetString("WR_S");
            atmForm.WR_Collect_L.Text = LangSwitch.GetString("WR_P");

            AudioHandler.PlayAudio("withdraw_success");
        }

        public override void OnBClicked(int b)
        {
            switch (b)
            {
                case 3: atmForm.SwitchState(atmForm.ATMWithdrawState); break;
            }
        }
    }
}
