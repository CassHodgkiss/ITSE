using ATM.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ATMStates
{
    public class ATMDepositResultsState : ATMBaseState
    {
        public ATMDepositResultsState(ATMForm atmForm) : base(atmForm)
        {
            LangSwitch.OnLangSwitch += () =>
            {
                atmForm.DR_Back_L.Text = LangSwitch.GetString("Misc_GB");
            };
        }

        public override void OnEnterState()
        {
            atmForm.DepositResults_P.Show();
        }

        public override void OnExitState()
        {
            atmForm.DepositResults_P.Hide();
        }

        public void SetResults(double amount, double newBal)
        {
            atmForm.DR_Amount_L.Text = LangSwitch.GetString("D_D") + amount;
            atmForm.DR_NewBal_L.Text = LangSwitch.GetString("R_NB") + newBal;
        }

        public override void OnBClicked(int b)
        {
            switch (b)
            {
                case 3: atmForm.SwitchState(atmForm.ATMDepositState); break;
            }
        }
    }
}
