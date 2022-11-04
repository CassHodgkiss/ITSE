using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public static class LanguageSwitcher
    {
        public static event Action OnLangSwitch;

        static Dictionary<string, Dictionary<string, string>> outputStrings = new Dictionary<string, Dictionary<string, string>>()
        {
            { "en", new Dictionary<string, string>()
            {
                { "Login_Promt",     "Waiting For CreditCard" },
                { "Login_EnterCard", "Enter Card" },

                { "MainOptions_Prompt",           "Select an Option" },
                { "MainOptions_Logout",           "Log Out" },
                { "MainOptions_ViewAccount",      "View Account" },
                { "MainOptions_WithdrawDeposits", "Withdraw Deposit" },
                { "MainOptions_Transfer",         "Transfer" },
                { "MainOptions_ViewStatement",    "View Statement" },

                { "Transfer_Prompt",        "Transfer Balance to Another Account" },
                { "Transfer_SelectAccount", "Input Account Id" },
                { "Transfer_SelectAmount",  "Input Amount" },
                { "Transfer_Transfer",      "Transfer" },

                { "Statement_Prompt", "Your Statement" },

                { "WithdrawDeposit_Prompt",   "Withdraw and Deposit into your Account" },
                { "WithdrawDeposit_Withdraw", "Withdraw" },
                { "WithdrawDeposit_Deposit",  "Deposit" },

                { "GoBack", "Go Back" },

                { "Misc_RemainingTries", "Remaining Tries:" },

                { "ATM_PinTitle",     "Pin" },
                { "ATM_PinPrompt",    "Input your Pin" },
                { "ATM_FailedPin",    "Pin Failed 3 Times\nSwallowing Card" },
                { "ATM_DepositZero",  "Cannot Deposit £0" },
                { "ATM_Deposit_0",    "Adding" },
                { "ATM_Deposit_1",    "to your Balance\nNew Balance:" },
                { "ATM_LTD",          "Cannot Withdraw Money from Long Term Deposit Accounts" },
                { "ATM_MaxWithdraw",  "Cannot Withdraw as Balance is 0" },
                { "ATM_Withdraw_00",  "Amount" },
                { "ATM_Withdraw_01",  "is over your Max Withdraw by" },
                { "ATM_Transfer",     "Transfering" },
                { "ATM_Withdraw",     "Withdrawing" },
                { "ATM_Transfer2FA",  "This is the first Transfer detected on this Account\nSending a code to" },
                { "ATM_2FAFailed",    "Failed 2FA" },
                { "ATM_Transfer_10",  "Transfering" },
                { "ATM_Transfer_11",  "to Account" },
                { "ATM_WithdrawZero", "Cannot Withdraw as Balance is £0" },
                { "ATM_Withdraw2FA",  "This is the first Withdraw detected on this Account\nSending a code to" },

                { "CardReader_WasSwallowed", "A Card with the same Card Number has been Swallowed, Invalid Card" },
                { "CardReader_NotFound",     "Credit Card not found" },
                { "CardReader_Eject_Title",  "CardReader" },
                { "CardReader_Eject_Prompt", "Card Ejected" },
                
                { "CashIO_Dispensed", "Cash Dispenced" },
                { "CashIO_Title",     "CashIO" },
                
                { "WithdrawDeposit_Withdraw_Title",  "Withdraw" },
                { "WithdrawDeposit_Withdraw_Prompt", "Input Withdraw Amount" },
                
                { "WithdrawDeposit_Deposit_Title",  "Deposit" },
                { "WithdrawDeposit_Deposit_Prompt", "Insert Deposit Amount" },

                { "Transfer_Account_Title",   "Account" },
                { "Transfer_Account_Prompt",  "Input Account Id" },
                { "Transfer_AccountNotFound", "Account could not be Found" },
                { "Transfer_AccountSame",     "Cannot transfer to Own Account" },
                { "Transfer_AccountFound",    "Valid Account Found of Id" },
                { "Transfer_Amount_Title",    "Amount" },
                { "Transfer_Amount_Prompt",   "Input Amount" },
                { "Transfer_AmountZero",      "Please Insert Amount more than 0" },
                { "Transfer_AmountSet",       "Set amount to" },
                { "Transfer_Transfer_0",      "Transfer" },
                { "Transfer_Transfer_1",      "to Account" },
                
                { "ViewAccount_Account", "Account Id:" },
                { "ViewAccount_Salary",  "Annual Salary:" },
                { "ViewAccount_Age",     "Age:" },
                { "ViewAccount_Balance", "Balance:" },
                { "ViewAccount_C",       "Current" },
                { "ViewAccount_SM",      "Simple Deposit" },
                { "ViewAccount_LTD",     "Long Term Deposit" },
                
                { "TransferM_Recieved_0", "Recieved" },
                { "TransferM_Recieved_1", "From" },
                { "TransferM_Send_0",     "Transfered" },
                { "TransferM_Send_1",     "To" },

                { "TwoFA_2FA_Title",  "2FA Code" },
                { "TwoFA_2FA_Prompt", "Input Your Code Here:" },
                { "TwoFA_2FA_Phone",  "Phone Notification Sim:\nYour code is:" },
            } },

            { "es", new Dictionary<string, string>()
            {
                { "Login_Promt",     "Waiting For CreditCard" },
                { "Login_EnterCard", "Enter Card" },

                { "MainOptions_Prompt",           "Select an Option" },
                { "MainOptions_Logout",           "Log Out" },
                { "MainOptions_ViewAccount",      "View Account" },
                { "MainOptions_WithdrawDeposits", "Withdraw Deposit" },
                { "MainOptions_Transfer",         "Transfer" },
                { "MainOptions_ViewStatement",    "View Statement" },

                { "Transfer_Prompt",        "Transfer Balance to Another Account" },
                { "Transfer_SelectAccount", "Input Account Id" },
                { "Transfer_SelectAmount",  "Input Amount" },
                { "Transfer_Transfer",      "Transfer" },

                { "Statement_Prompt", "Your Statement" },

                { "WithdrawDeposit_Prompt",   "Withdraw and Deposit into your Account" },
                { "WithdrawDeposit_Withdraw", "Withdraw" },
                { "WithdrawDeposit_Deposit",  "Deposit" },

                { "GoBack", "Go Back" },

                { "Misc_RemainingTries", "Remaining Tries:" },

                { "ATM_PinTitle",     "Pin" },
                { "ATM_PinPrompt",    "Input your Pin" },
                { "ATM_FailedPin",    "Pin Failed 3 Times\nSwallowing Card" },
                { "ATM_DepositZero",  "Cannot Deposit £0" },
                { "ATM_Deposit_0",    "Adding" },
                { "ATM_Deposit_1",    "to your Balance\nNew Balance:" },
                { "ATM_LTD",          "Cannot Withdraw Money from Long Term Deposit Accounts" },
                { "ATM_MaxWithdraw",  "Cannot Withdraw as Balance is 0" },
                { "ATM_Withdraw_00",  "Amount" },
                { "ATM_Withdraw_01",  "is over your Max Withdraw by" },
                { "ATM_Transfer",     "Transfering" },
                { "ATM_Withdraw",     "Withdrawing" },
                { "ATM_Transfer2FA",  "This is the first Transfer detected on this Account\nSending a code to" },
                { "ATM_2FAFailed",    "Failed 2FA" },
                { "ATM_Transfer_10",  "Transfering" },
                { "ATM_Transfer_11",  "to Account" },
                { "ATM_WithdrawZero", "Cannot Withdraw as Balance is £0" },
                { "ATM_Withdraw2FA",  "This is the first Withdraw detected on this Account\nSending a code to" },

                { "CardReader_WasSwallowed", "A Card with the same Card Number has been Swallowed, Invalid Card" },
                { "CardReader_NotFound",     "Credit Card not found" },
                { "CardReader_Eject_Title",  "CardReader" },
                { "CardReader_Eject_Prompt", "Card Ejected" },

                { "CashIO_Dispensed", "Cash Dispenced" },
                { "CashIO_Title",     "CashIO" },

                { "WithdrawDeposit_Withdraw_Title",  "Withdraw" },
                { "WithdrawDeposit_Withdraw_Prompt", "Input Withdraw Amount" },

                { "WithdrawDeposit_Deposit_Title",  "Deposit" },
                { "WithdrawDeposit_Deposit_Prompt", "Insert Deposit Amount" },

                { "Transfer_Account_Title",   "Account" },
                { "Transfer_Account_Prompt",  "Input Account Id" },
                { "Transfer_AccountNotFound", "Account could not be Found" },
                { "Transfer_AccountSame",     "Cannot transfer to Own Account" },
                { "Transfer_AccountFound",    "Valid Account Found of Id" },
                { "Transfer_Amount_Title",    "Amount" },
                { "Transfer_Amount_Prompt",   "Input Amount" },
                { "Transfer_AmountZero",      "Please Insert Amount more than 0" },
                { "Transfer_AmountSet",       "Set amount to" },
                { "Transfer_Transfer_0",      "Transfer" },
                { "Transfer_Transfer_1",      "to Account" },

                { "ViewAccount_Account", "Account Id:" },
                { "ViewAccount_Salary",  "Annual Salary:" },
                { "ViewAccount_Age",     "Age:" },
                { "ViewAccount_Balance", "Balance:" },
                { "ViewAccount_C",       "Current" },
                { "ViewAccount_SM",      "Simple Deposit" },
                { "ViewAccount_LTD",     "Long Term Deposit" },

                { "TransferM_Recieved_0", "Recieved" },
                { "TransferM_Recieved_1", "From" },
                { "TransferM_Send_0",     "Transfered" },
                { "TransferM_Send_1",     "To" },

                { "TwoFA_2FA_Title",  "2FA Code" },
                { "TwoFA_2FA_Prompt", "Input Your Code Here:" },
                { "TwoFA_2FA_Phone",  "Phone Notification Sim:\nYour code is:" },
            } },
        };

        static string lang = "en";

        public static void SwitchLanguage(string newLang)
        {
            if (!outputStrings.ContainsKey(newLang)) return;        
            if (lang == newLang) return;

            lang = newLang;
            OnLangSwitch?.Invoke();       
        }

        public static string GetString(string index)
        {
            return outputStrings[lang][index];
        }
    }
}
