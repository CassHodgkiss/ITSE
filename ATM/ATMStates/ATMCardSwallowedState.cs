using ATM.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ATMStates
{
    public class ATMCardSwallowedState : ATMBaseState
    {
        public ATMCardSwallowedState(ATMForm atmForm) : base(atmForm)
        {
            LangSwitch.OnLangSwitch += () =>
            {
                atmForm.CardS_Prompt_L.Text = LangSwitch.GetString("CS_E");
                atmForm.CardS_Back_L.Text =   LangSwitch.GetString("Misc_GB");
            };
        }

        public override void OnEnterState()
        {
            atmForm.CardSwallowed_P.Show();
        }

        public override void OnExitState()
        {
            atmForm.CardSwallowed_P.Hide();
        }

        public override void OnBClicked(int b)
        {
            switch (b)
            {
                case 3: atmForm.SwitchState(atmForm.ATMWaitingForCardState); break;
            }
        }
    }
}
