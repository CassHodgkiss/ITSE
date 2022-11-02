using SQLiteDataAccess;
using ATM.Models;

namespace ATM
{
    public class Accounts // Collection
    {
        List<AccountM> accounts = new List<AccountM>();

        public Accounts()
        {
            //Current Accounts
            string sqlc = 
                @"Select * From Currents c 
                Left Join Accounts a on a.Id = c.AccountId 
                Left Join CreditCards cc on cc.Id = a.CreditCardId 
                Left Join Customers cu on cu.Id = a.CustomerId";
            accounts.AddRange(SQLiteAccess.Read<CurrentM, CreditCardM, CustomerM>(sqlc, 
                (current, card, customer) => { current.CreditCard = card; current.Customer = customer; return current; }, 
                new { }));

            //Simple Deposit Accounts
            string sqlsd =
                @"Select * From SimpleDeposits sd 
                Left Join Accounts a on a.Id = sd.AccountId 
                Left Join CreditCards cc on cc.Id = a.CreditCardId 
                Left Join Customers cu on cu.Id = a.CustomerId";
            accounts.AddRange(SQLiteAccess.Read<SimpleDepositM, CreditCardM, CustomerM>(sqlsd,
                (deposit, card, customer) => { deposit.CreditCard = card; deposit.Customer = customer; return deposit; },
                new { }));

            //Long Term Deposit Accounts
            string sqlltd =
                @"Select * From LongTermDeposits ltd 
                Left Join Accounts a on a.Id = ltd.AccountId 
                Left Join CreditCards cc on cc.Id = a.CreditCardId 
                Left Join Customers cu on cu.Id = a.CustomerId";
            accounts.AddRange(SQLiteAccess.Read<LongTermDepositM, CreditCardM, CustomerM>(sqlltd,
                (ltdeposit, card, customer) => { ltdeposit.CreditCard = card; ltdeposit.Customer = customer; return ltdeposit; },
                new { }));
        }

        public void UpdateAccount(AccountM account)
        {
            string sql = @"Update Accounts Set Balance = @Balance, PinHash = @PinHash, IsFrozen = @IsFrozen
                         Where Id = @Id";
            SQLiteAccess.Write(sql, account);
        }

        public AccountM SearchByCreditCard(CreditCardM creditCard)
        {
            AccountM account = accounts.Find(a => a.CreditCard.Id == creditCard.Id);
            return account;
        }

        internal AccountM SearchByAccountId(int id)
        {
            AccountM account = accounts.Find(a => a.Id == id);
            return account;
        }
    }
}
