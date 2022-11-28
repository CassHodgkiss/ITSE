using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Models
{
    public class AccountM
    {
        public int Id { get; set; }

        public double Balance { get; set; }
        public string PinHash { get; set; }
        public bool IsFrozen { get; set; }

        public CreditCardM CreditCard { get; set; }
        public CustomerM Customer { get; set; }

        public string Id_String
        {
            get
            {
                string id_string = Id.ToString();
                int leadZeros = 6 - id_string.Length;

                string leadZeros_string = new string('0', leadZeros);

                return leadZeros_string + id_string;
            }
        }
    }
}
