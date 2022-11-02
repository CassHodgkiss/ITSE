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
        public event Action OnLogin;

        CardReader cardReader;
        CashIO cashIO;

        Accounts accounts;
        Transactions transactions;

        AccountM currentAccount;

        public ATM(CardReader cardReader, CashIO cashIO)
        {
            this.cardReader = cardReader;
            this.cashIO = cashIO;

            accounts = new Accounts();
            transactions = new Transactions();

            cardReader.LinkATM(this);
            cashIO.LinkAtm(this);
        }

        // Called when CardReader detects a CreditCard inserted and it is validated
        public void CreditCardScanned(CreditCardM creditCard)
        {
            AccountM account = accounts.SearchByCreditCard(creditCard);
            if (account == null) return;

            InputBox inputBox = new InputBox("Pin", "Input your Pin");

            int tries = 0;

            while (tries < 3)
            {
                string hash;
                do
                {
                    inputBox.ShowDialog();
                    hash = inputBox.Input_TB.Text;
                } while (hash.Length != 4);

                if (Hash.VerifyHash(hash, account.PinHash))
                {
                    currentAccount = account; 
                    OnLogin?.Invoke();
                    return;
                }

                tries++;
                MessageBox.Show("Remaining Tries: " + (3 - tries));
                inputBox.Input_TB.Clear();
            }

            MessageBox.Show("Pin Failed 3 Times\nSwallowing Card");

            cardReader.SwallowCard();
        }

        //Called from CashIO when cash is detected to deposit an amount
        public void Deposit(double amount)
        {
            if(amount == 0)
            {
                MessageBox.Show("Cannot Deposit £0");
                return;
            }

            MessageBox.Show($"Adding £{amount} to your Balance\nNew Balance: £{currentAccount.Balance}");

            currentAccount.Balance += amount;
            transactions.CreateWithdrawDeposit(currentAccount, amount, false);
            accounts.UpdateAccount(currentAccount);
        }

        public void Transfer(AccountM transferTo, double amount)
        {
            if (currentAccount is LongTermDepositM)
            {
                MessageBox.Show("Cannot Transfer out of Long Term Deposit Accounts");
                return;
            }

            double maxWithdraw = GetWithdrawLimit();

            if (maxWithdraw == 0)
            {
                MessageBox.Show("Cannot Withdraw as Balance is 0");
                return;
            }

            if (amount > maxWithdraw)
            {
                MessageBox.Show($"Amount £{amount} is over your Max Withdraw by £{amount - maxWithdraw}\nTransfering £{maxWithdraw}");
                amount = maxWithdraw;
            }

            if (!transactions.HasTransfered(currentAccount))
            {
                MessageBox.Show($"This is the first Transfer detected on this Account\nSending a code to {currentAccount.Customer.PhoneNumber}");

                if (!TwoFA.TwoFASim())
                {
                    MessageBox.Show("Failed 2FA");
                    return;
                }
            }

            currentAccount.Balance -= amount;
            transferTo.Balance += amount;

            transactions.CreateTransfer(currentAccount, transferTo, amount, false);
            transactions.CreateTransfer(transferTo, currentAccount, amount, true);

            accounts.UpdateAccount(currentAccount);
            accounts.UpdateAccount(transferTo);

            MessageBox.Show($"Transfering £{amount} to Account {transferTo.Id}");
        }

        //Called from UI to withdraw a certain amount
        public void Withdraw(double amount)
        {
            if (currentAccount is LongTermDepositM)
            {
                MessageBox.Show("Cannot Withdraw from Long Term Deposit Accounts");
                return;
            }

            double maxWithdraw = GetWithdrawLimit();

            if(maxWithdraw == 0)
            {
                MessageBox.Show("Cannot Withdraw as Balance is 0");
                return;
            }

            if (amount > maxWithdraw)
            {
                MessageBox.Show($"Amount £{amount} is over your Max Withdraw by £{amount - maxWithdraw}\nWithdrawing £{maxWithdraw}");
                amount = maxWithdraw;
            }

            if (!transactions.HasWithdrawn(currentAccount))
            {
                MessageBox.Show($"This is the first Withdraw detected on this Account\nSending a code to {currentAccount.Customer.PhoneNumber}");

                if (!TwoFA.TwoFASim())
                {
                    MessageBox.Show("Failed 2FA");
                    return;
                }
            }

            currentAccount.Balance -= amount;
            transactions.CreateWithdrawDeposit(currentAccount, amount, true);
            accounts.UpdateAccount(currentAccount);
            cashIO.Dispense(amount);
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

        public Transactions GetTransactions() { return transactions; }

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

            return maxWithdraw;
        }
    }
}
