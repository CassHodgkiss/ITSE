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
            List<double> cashOuput = MoneyToCash(amount);

            string output = $"{LanguageSwitcher.GetString("CashIO_Dispensed")} £{amount}\n";
            cashOuput.ForEach(c => output += $"£{c}\n");

            MessageBox.Show(output, LanguageSwitcher.GetString("CashIO_Title"));
        }

        public void TakeIn(double amount)
        {
            atm.Deposit(amount);
        }

        List<double> MoneyToCash(double amount)
        {
            double[] cashTypes = new double[] { 50, 20, 10, 5, 2, 1, 0.5, 0.2, 0.1, 0.05, 0.02, 0.01 };

            List<double> cashOuput = new List<double>();

            while (amount >= 0.01)
            {
                for (int i = 0; i < cashTypes.Length; i++)
                {
                    double cashType = cashTypes[i];
                    if (amount >= cashType)
                    {
                        cashOuput.Add(cashType);
                        amount -= cashType;
                        break;
                    }
                }
            }

            return cashOuput;
        }
    }
}
