using ATM.Models;
using SQLiteDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Classes
{
    public class Customers
    {
        public Dictionary<int, CustomerM> customers { get; }

        public Customers()
        {
            customers = new Dictionary<int, CustomerM>();

            string sqlc = @"Select * From Customers";
            var cs = SQLiteAccess.Read<CustomerM>(sqlc, new { });

            string sqlsc = @"Select * From SpecialCustomers sc
                            Left Join Customers c on c.Id = sc.CustomerId";
            var scs = SQLiteAccess.Read<SpecialCustomerM>(sqlsc, new { });

            foreach (var sc in scs)
                customers.Add(sc.Id, sc);

            foreach (var c in cs)
            {
                if (!customers.ContainsKey(c.Id))
                    customers.TryAdd(c.Id, c);
            }
        }
    }
}
