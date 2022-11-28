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
        protected ATMForm atmForm;

        public ATMBaseState(ATMForm atmForm)
        {
            this.atmForm = atmForm;
        }

        public virtual void OnEnterState() { }
        public virtual void OnExitState() { }
        public virtual void OnBClicked(int b) { }
        public virtual void OnNClicked(int n) { }
        public virtual void OnBackSpaceClicked() { }
        public virtual void OnEnterClicked() { }
    }
}
