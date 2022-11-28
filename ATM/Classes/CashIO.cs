using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class CashIO
    {
        ATM atm;

        public void LinkAtm(ATM atm)
        {
            this.atm = atm;
        }

        //Called from ATM to output money to the ATM User
        public void Dispense(double amount)
        {
            
        }

        public void TakeIn(double amount)
        {
            atm.Deposit(amount);
        }
    }
}
