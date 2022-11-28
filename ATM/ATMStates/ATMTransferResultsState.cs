using ATM.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ATMStates
{
    public class ATMTransferResultsState : ATMBaseState
    {
        public ATMTransferResultsState(ATMForm atmForm) : base(atmForm)
        {
            LangSwitch.OnLangSwitch += () =>
            {
                atmForm.TR_Back_L.Text = LangSwitch.GetString("Misc_GB");
            };
        }

        public override void OnEnterState()
        {
            atmForm.TransferResults_P.Show();
        }

        public override void OnExitState()
        {
            atmForm.TransferResults_P.Hide();
        }

        public void SetResults(string accountId, double withdrew, double balance, bool isOverMax, double max = 0)
        {
            if (isOverMax)
            {
                if (max == 0)
                {
                    atmForm.TR_Prompt_L.Text = LangSwitch.GetString("TR_NS");
                    atmForm.TR_T_L.Text = "";
                    atmForm.TR_NewBal_L.Text = "";
                    atmForm.TR_Error_L.Text = LangSwitch.GetString("TR_ALR");
                    AudioHandler.PlayAudio("transfer_failed");
                    return;
                }

                atmForm.TR_T_L.Text = $"{LangSwitch.GetString("TR_T1")}{max} {LangSwitch.GetString("TR_T2")} {accountId}";
                atmForm.TR_NewBal_L.Text = $"{LangSwitch.GetString("R_NB")}{balance}";
                atmForm.TR_Error_L.Text = $"{LangSwitch.GetString("TR_OT1")}{max} {LangSwitch.GetString("TR_OT2")}{withdrew} {LangSwitch.GetString("R_ALR")}";
            }
            else
            {
                atmForm.TR_T_L.Text = $"{LangSwitch.GetString("TR_T1")}{withdrew} {LangSwitch.GetString("TR_T2")} {accountId}";
                atmForm.TR_NewBal_L.Text = $"{LangSwitch.GetString("R_NB")}{balance}";
                atmForm.TR_Error_L.Text = "";
            }

            atmForm.TR_Prompt_L.Text = LangSwitch.GetString("TR_S");
            AudioHandler.PlayAudio("transfer_success");
        }

        public override void OnBClicked(int b)
        {
            switch (b)
            {
                case 3: atmForm.SwitchState(atmForm.ATMTransferState); break;
            }
        }
    }
}
