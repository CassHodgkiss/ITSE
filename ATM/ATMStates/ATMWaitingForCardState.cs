using ATM.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ATMStates
{
    public class ATMWaitingForCardState : ATMBaseState
    {
        public override void OnEnterState(ATMForm atmForm)
        {
            atmForm.WaitingForCard_P.Show();
        }

        public override void OnExitState(ATMForm atmForm)
        {
            atmForm.WaitingForCard_P.Hide();
        }

        public override void OnB1Clicked(ATMForm atmForm)
        {
            throw new NotImplementedException();
        }

        public override void OnB2Clicked(ATMForm atmForm)
        {
            throw new NotImplementedException();
        }

        public override void OnB3Clicked(ATMForm atmForm)
        {
            throw new NotImplementedException();
        }

        public override void OnB4Clicked(ATMForm atmForm)
        {
            throw new NotImplementedException();
        }

        public override void OnB5Clicked(ATMForm atmForm)
        {
            throw new NotImplementedException();
        }

        public override void OnB6Clicked(ATMForm atmForm)
        {
            throw new NotImplementedException();
        }
    }
}
