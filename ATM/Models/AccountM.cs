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
    }
}
