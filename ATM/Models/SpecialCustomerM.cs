using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Models
{
    public class SpecialCustomerM : CustomerM
    {
        public double OverdraftPercentage { get; set; }

        public double OverDraft { get { return AnnualSalary * OverdraftPercentage; } }
    }
}
