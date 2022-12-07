using ATM.Classes;
using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class ATM
    {
        public event Action OnAccountFrozen;
        public event Action OnAccountFound;
        public event Action OnAccountNotFound;

        CardReader cardReader;
        CashIO cashIO;

        Customers customers;
        public Accounts accounts;
        Transactions transactions;

        AccountM currentAccount;

        public ATM(CardReader cardReader, CashIO cashIO)
        {
            this.cardReader = cardReader;
            this.cashIO = cashIO;

            customers = new Customers();
            accounts = new Accounts(customers);
            transactions = new Transactions();

            cardReader.LinkATM(this);
            cashIO.LinkAtm(this);
        }

        public void CreditCardScanned()
        {
            CreditCardM creditCard = cardReader.CurrentCreditCard;
            currentAccount = accounts.SearchByCreditCard(creditCard);
            if(currentAccount == null)
            {
                cardReader.EjectCard();
                OnAccountNotFound?.Invoke();
            }
            else if (currentAccount.IsFrozen == true)
            {
                currentAccount = null;
                cardReader.EjectCard();
                OnAccountFrozen?.Invoke();
            }
            else
            {
                OnAccountFound?.Invoke();
            }
        }

        public bool PinInput(string pin)
        {
            return Hash.VerifyHash(pin, currentAccount.PinHash);
        }

        public void Deposit(double amount)
        {
            currentAccount.Balance += amount;
            transactions.CreateWithdrawDeposit(currentAccount, amount, false);
            accounts.UpdateAccount(currentAccount);
        }

        public double GetMaxWithdraw()
        {
            return GetWithdrawLimit();
        }

        public bool VerifyIf2FAWithdraw()
        {
            return !transactions.HasWithdrawn(currentAccount);
        }

        public bool VerifyIf2FATransfer()
        {
            return !transactions.HasTransfered(currentAccount);
        }

        public void Withdraw(double amount)
        {
            currentAccount.Balance -= amount;
            transactions.CreateWithdrawDeposit(currentAccount, amount, true);
            accounts.UpdateAccount(currentAccount);
            cashIO.Dispense(amount);
        }

        public void Transfer(AccountM transferTo, double amount)
        {
            currentAccount.Balance -= amount;
            transferTo.Balance += amount;

            transactions.CreateTransfer(currentAccount, transferTo, amount, false);
            transactions.CreateTransfer(transferTo, currentAccount, amount, true);

            accounts.UpdateAccount(currentAccount);
            accounts.UpdateAccount(transferTo);
        }

        public AccountM GetAccountById(int id)
        {
            return accounts.SearchByAccountId(id);
        }

        public void Logout()
        {
            currentAccount = null;
            cardReader.EjectCard();
        }

        public List<TransactionM> GetLastTransactions()
        {
            return transactions.GetLastTransactions(currentAccount);
        }

        public AccountM GetAccount()
        {
            return currentAccount;
        }

        double GetWithdrawLimit()
        {
            double maxWithdraw = 0;

            if (currentAccount is CurrentM current)
            {
                if (current.Customer is SpecialCustomerM specialCustomer)
                {
                    maxWithdraw = current.Balance + specialCustomer.OverDraft;
                }
                else
                {
                    maxWithdraw = current.Balance;
                }
            }

            else if (currentAccount is SimpleDepositM simpleDeposit)
            {
                maxWithdraw = simpleDeposit.Balance;
            }

            //Just in case of Floating Point errors
            if (maxWithdraw <= 0.001f) maxWithdraw = 0;

            return maxWithdraw;
        }
    }
}
