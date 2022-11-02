using ATM.Models;
using SQLiteDataAccess;

namespace ATM
{
    public class Transactions // Collection
    {
        List<TransactionM> transactions = new List<TransactionM>();

        public Transactions()
        {
            //Transfer
            string sqlt =
                @"Select * From Transfers t 
                Left Join Transactions tr on tr.Id = t.TransactionId 
                Left Join Accounts m on m.Id = tr.AccountId 
                Left Join Accounts o on o.Id = t.AccountOtherId
                ORDER BY tr.DateCreated DESC";
            transactions.AddRange(SQLiteAccess.Read<TransferM, AccountM, AccountM>(sqlt,
                (transfer, main, other) => { transfer.Account = main; transfer.AccountOther = other; return transfer; },
                new { }));

            //WithdrawDeposit
            string sqlwd =
                @"Select * From WithdrawDeposits wd 
                Left Join Transactions tr on tr.Id = wd.TransactionId 
                Left Join Accounts m on m.Id = tr.AccountId
                ORDER BY tr.DateCreated DESC";
            transactions.AddRange(SQLiteAccess.Read<WithdrawDepositM, AccountM>(sqlwd,
                (transfer, main) => { transfer.Account = main; return transfer; },
                new { }));
        }

        public List<TransactionM> GetLastTransactions(AccountM account, int amount = 10)
        {
            List<TransactionM> statement = new List<TransactionM>();

            transactions.ForEach(t => { if (t.Account.Id == account.Id) statement.Add(t); });

            statement.Sort((a, b) => DateTime.Compare(DateTime.Parse(b.DateCreated), DateTime.Parse(a.DateCreated)));
            return statement.Take(amount).ToList();
        }

        public void CreateWithdrawDeposit(AccountM account, double amount, bool isWithdrawn)
        {
            WithdrawDepositM transfer = new WithdrawDepositM()
            {
                Account = account,
                DateCreated = DateTime.Now.ToString(),
                Amount = amount,
                IsWithdrawn = isWithdrawn
            };

            //Transactions
            string sqlt = @"Insert Into Transactions (DateCreated, Amount, AccountId)
                         values (@DateCreated, @Amount, @AccountId)";
            transfer.Id = SQLiteAccess.WriteReturnPk(sqlt, 
                new {transfer.DateCreated, transfer.Amount, AccountId = account.Id});

            //WithdrawDeposits
            string sqltr = @"Insert Into WithdrawDeposits (TransactionId, IsWithdrawn)
                         values (@Id, @IsWithdrawn)";
            SQLiteAccess.Write(sqltr, new { transfer.Id, transfer.IsWithdrawn });

            transactions.Add(transfer);
        }

        public void CreateTransfer(AccountM account, AccountM accountOther, double amount, bool isRecieved)
        {
            TransferM transfer = new TransferM()
            {
                Account = account,
                AccountOther = accountOther,
                DateCreated = DateTime.Now.ToString(),
                Amount = amount,
                IsRecieved = isRecieved
            };

            //Transactions
            string sqlt = @"Insert Into Transactions (DateCreated, Amount, AccountId)
                         values (@DateCreated, @Amount, @AccountId)";
            transfer.Id = SQLiteAccess.WriteReturnPk(sqlt,
                new { transfer.DateCreated, transfer.Amount, AccountId = account.Id });

            //Transfers
            string sqltr = @"Insert Into Transfers (TransactionId, IsRecieved, AccountOtherId)
                         values (@Id, @IsRecieved, @AccountOtherId)";
            SQLiteAccess.Write(sqltr, new { transfer.Id, transfer.IsRecieved, AccountOtherId = accountOther.Id });

            transactions.Add(transfer);
        }

        public bool HasWithdrawn(AccountM account)
        {
            foreach (var transaction in transactions)
            {
                if(transaction is WithdrawDepositM withdrawDeposit && transaction.Account.Id == account.Id && withdrawDeposit.IsWithdrawn == true)
                {
                    return true;
                }
            }

            return false;
        }

        public bool HasTransfered(AccountM account)
        {
            foreach (var transaction in transactions)
            {
                if (transaction is TransferM transfer && transaction.Account.Id == account.Id && transfer.IsRecieved == false)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
