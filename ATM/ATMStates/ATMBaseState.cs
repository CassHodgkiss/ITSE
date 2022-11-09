using ATM.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ATMStates
{
    public abstract class ATMBaseState
    {
        public abstract void OnEnterState(ATMForm atmForm);
        public abstract void OnExitState(ATMForm atmForm);
        public abstract void OnB1Clicked(ATMForm atmForm);
        public abstract void OnB2Clicked(ATMForm atmForm);
        public abstract void OnB3Clicked(ATMForm atmForm);
        public abstract void OnB4Clicked(ATMForm atmForm);
        public abstract void OnB5Clicked(ATMForm atmForm);
        public abstract void OnB6Clicked(ATMForm atmForm);
    }
}
