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

                { "WithdrawDepositM_Deposited", "Deposited" },
                { "WithdrawDepositM_Withdrew", "Withdrew" },

                { "TwoFA_2FA_Title",  "2FA Code" },
                { "TwoFA_2FA_Prompt", "Input Your Code Here:" },
                { "TwoFA_2FA_Phone",  "Phone Notification Sim:\nYour code is:" },
            } },

            { "es", new Dictionary<string, string>()
            {
                { "Login_Promt",     "Esperando la Tarjeta Banco" },
                { "Login_EnterCard", "Entrar Tarjeta" },
                
                { "MainOptions_Prompt",           "Seleccione un opción" },
                { "MainOptions_Logout",           "Cerrar Sesión"},
                { "MainOptions_ViewAccount",      "Ver Cuenta" },
                { "MainOptions_WithdrawDeposits", "Sacar Depósito" },
                { "MainOptions_Transfer",         "Transferir" },
                { "MainOptions_ViewStatement",    "Ver Estado de Cuenta" },
                
                { "Transfer_Prompt",        "Transferencia Saldo a Otra Cuenta" },
                { "Transfer_SelectAccount", "Entrada Id de Cuenta" },
                { "Transfer_SelectAmount",  "Entrada Cantidad" },
                { "Transfer_Transfer",      "Transferir" },
                
                { "Statement_Prompt", "Su Estado de Cuenta" },
                
                { "WithdrawDeposit_Prompt",   "Sacar y Depositar en su Cuenta" },
                { "WithdrawDeposit_Withdraw", "Sacar" },
                { "WithdrawDeposit_Deposit",  "Depositar" },
                
                { "GoBack", "Volver" },
                
                { "Misc_RemainingTries", "Intentos Restantes:" },
                
                { "ATM_PinTitle",     "Pin" },
                { "ATM_PinPrompt",    "Entrada su Pin" },
                { "ATM_FailedPin",    "Pin Incorrecto 3 Veces\nTragar Tarjeta" },
                { "ATM_DepositZero",  "No se puede Depositar £0" },
                { "ATM_Deposit_0",    "Agregar" },
                { "ATM_Deposit_1",    "a tu Saldo\nSaldo Nuevo:" },
                { "ATM_LTD",          "No se puede Sacar Dinero de la Cuenta de Depósito a Largo Cuenta" },
                { "ATM_MaxWithdraw",  "No se puede Sacar porque el Saldo es 0" },
                { "ATM_Withdraw_00",  "Cantidad" },
                { "ATM_Withdraw_01",  "ha superado su Retiro Máximo por" },
                { "ATM_Transfer",     "Transfiriendo" },
                { "ATM_Withdraw",     "Retirando" },
                { "ATM_Transfer2FA",  "Esta es la Primera Transferencia detectada en esta Cuenta\nEnviar un Código a" },
                { "ATM_2FAFailed",    "2FA Fallido" },
                { "ATM_Transfer_10",  "Transfiriendo" },
                { "ATM_Transfer_11",  "a Cuenta" },
                { "ATM_WithdrawZero", "No se puede Sacar como saldo es 0" },
                { "ATM_Withdraw2FA",  "Este es el Primer Retiro Detectado en esta Cuenta\nEnviar un Código a" },
                
                { "CardReader_WasSwallowed", "Una tarjeta con el mismo número de tarjeta ha sido tragada, tarjeta no válida" },
                { "CardReader_NotFound",     "Tarjeta no encontrada" },
                { "CardReader_Eject_Title",  "Lector de Tarjetas" },
                { "CardReader_Eject_Prompt", "Tarjeta Expulsado" },
                
                { "CashIO_Dispensed", "Dinero Dispensados" },
                { "CashIO_Title",     "DineroIO" },
                
                { "WithdrawDeposit_Withdraw_Title",  "Sacar" },
                { "WithdrawDeposit_Withdraw_Prompt", "Entrada Cantidad de Retiro" },
                
                { "WithdrawDeposit_Deposit_Title",  "Depósito" },
                { "WithdrawDeposit_Deposit_Prompt", "Entrada Cantidad de Depósito" },
                
                { "Transfer_Account_Title",   "Cuenta" },
                { "Transfer_Account_Prompt",  "Entrada Cuenta Id" },
                { "Transfer_AccountNotFound", "No se pudo Encontrar la Cuenta" },
                { "Transfer_AccountSame",     "No se puede Transferir a su Propia Cuenta" },
                { "Transfer_AccountFound",    "Cuenta válida encontrada desde ID" },
                { "Transfer_Amount_Title",    "Cantidad" },
                { "Transfer_Amount_Prompt",   "Entrada Cantidad" },
                { "Transfer_AmountZero",      "Por favor, inserte la cantidad mejor a 0" },
                { "Transfer_AmountSet",       "Establezca la cantidad en" },
                { "Transfer_Transfer_0",      "Transfiriendo" },
                { "Transfer_Transfer_1",      "a Cuenta" },
                
                { "ViewAccount_Account", "Cuenta Id:" },
                { "ViewAccount_Salary",  "Salario Anual:" },
                { "ViewAccount_Age",     "Edad:" },
                { "ViewAccount_Balance", "Saldo:" },
                { "ViewAccount_C",       "Corriente" },
                { "ViewAccount_SM",      "Depósito Simple" },
                { "ViewAccount_LTD",     "Depósito Largo Plazo" },
                
                { "TransferM_Recieved_0", "Recibido" },
                { "TransferM_Recieved_1", "De" },
                { "TransferM_Send_0",     "Transferido" },
                { "TransferM_Send_1",     "a" },

                { "WithdrawDepositM_Deposited", "Depositado" },
                { "WithdrawDepositM_Withdrew", "Sacar" },

                { "TwoFA_2FA_Title",  "2FA Codigo" },
                { "TwoFA_2FA_Prompt", "Introduce tu Código Aquí:" },
                { "TwoFA_2FA_Phone",  "Notificación Telefónica Simulación:\nSu código es:" },
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
