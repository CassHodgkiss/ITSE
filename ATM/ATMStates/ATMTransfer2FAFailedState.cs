using ATM.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ATMStates
{
    public class ATMTransfer2FAFailedState : ATMBaseState
    {
        public ATMTransfer2FAFailedState(ATMForm atmForm) : base(atmForm)
        {
            LangSwitch.OnLangSwitch += () =>
            {
                atmForm.T2FA_Prompt_L.Text = LangSwitch.GetString("T2FA");
                atmForm.T2FA_Back_L.Text =   LangSwitch.GetString("Misc_GB");
            };
        }

        public override void OnEnterState()
        {
            atmForm.Transfer2FAFailed_P.Show();
        }

        public override void OnExitState()
        {
            atmForm.Transfer2FAFailed_P.Hide();
        }

        public override void OnBClicked(int b)
        {
            switch (b)
            {
                case 3: atmForm.SwitchState(atmForm.ATMMainOptionsState); break;
            }
        }
    }
}
