using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public static class LangSwitch
    {
        public static event Action OnLangSwitch;

        static Dictionary<string, Dictionary<string, string>> outputStrings = new Dictionary<string, Dictionary<string, string>>()
        {
            { "en", new Dictionary<string, string>()
            {
                { "VA_O",    "Overdraft" },
                { "WFC_P",   "Please Insert Card into Card Reader" },
                { "CS_E",    "Due to Failing to input your Pin 3 Times, your Card has been Suspended" },
                { "W2FA",    "Withdrawal Failed due to Failure to Complete 2FA" },
                { "2FA",     "To Verify your Identity a Code has been Sent to your Phone" },
                { "T2FA",    "Transfer Failed due to Failure to Complete 2FA" },
                { "TR_S",    "Your Transfer was Successful" },
                { "TR_NS",   "Your Transfer wasn't Successful" },
                { "TR_ALR",  "Could not Transfer as Account Limit Reached" },
                { "TR_OT1",  "Only Transfered £" },
                { "TR_OT2",  "of £" },
                { "TR_T1",   "Transfered: £" },
                { "TR_T2",   "to" },
                { "T_NF",    "Account Not Found" },
                { "T_SA",    "Cannot Transfer to Own Account" },
                { "T_M",     "Please Input the Amount of Money you would like to Transfer" },
                { "Misc_C",  "Confirm" },
                { "T_AN",    "Please Input the Account Number you would like to Transfer to" },
                { "W_W",     "Withdrawing: £" },
                { "V_0",     "Value must be over £0" },
                { "D_P",     "To Deposit, Insert Bills into the Machine" },
                { "DR_D1",   "Your Deposit was Successful" },
                { "D_D",     "Deposited: £" },
                { "WR_S",    "Your Withdrawal was Successful" },
                { "WR_NS",   "Your Withdrawal wasn't Successful" },
                { "WR_W1",   "Withdrew: £" },
                { "WR_OW1",  "Only Withdrew £ " },
                { "WR_OW2",  "of £" },
                { "WR_ALR",  "Due to Exceding Account Limit" },
                { "R_NB",    "New Account Balance: £" },
                { "WR_P",    "Please Collect your Cash" },
                { "WR_CNW",  "Could not Withdraw as Account Limit Reached" },
                { "Misc_GB", "Go Back" },
                { "VA_AN",   "Account Number:" },
                { "VA_S",    "Annual Salary:" },
                { "VA_A",    "Age:" },
                { "VA_B",    "Balance:" },
                { "VA_C",    "Current" },
                { "VA_SM",   "Simple Deposit" },
                { "VA_LTD",  "Long Term Deposit" },
                { "VS_P",    "Your Statement" },
                { "VS_R1",   "Recieved" },
                { "VS_R2",   "From" },
                { "VS_T1",   "Transfered" },
                { "VS_T2",   "To" },
                { "VS_D",    "Deposited" },
                { "VS_W",    "Withdrew" },
                { "D",       "Deposit" },
                { "T",       "Transfer" },
                { "MO_EC",   "Eject Card" },
                { "MO_VA",   "View Account" },
                { "MO_W",    "Withdraw" },
                { "MO_VS",   "View Statement" },
                { "P_P",     "Please Input your Pin Code" },
                { "P_PI",    "Pin is Incorrect, Tries Remaining:" },
                { "WFC_CS",  "A Card with the same Card Number has been Suspended, Invalid Card" },
                { "WFC_NF",  "Credit Card not found" },
                { "W_IWA",   "Input Withdraw Amount" },
                { "T_IA",    "Input Amount" },
                { "WFC_AF",  "Your Account is Frozen" }
            } },

            { "es", new Dictionary<string, string>()
            {
                { "VA_O",    "Descubierto" },
                { "WFC_P",   "Inserte la Tarjeta en el Lector de Tarjetas Por Favor" },
                { "CS_E",    "Debido a que no ingresó su PIN 3 veces, su tarjeta ha sido suspendida" },
                { "W2FA",    "Retiro fallido debido a la falta de completar 2FA" },
                { "2FA",     "Para verificar su identidad, se ha enviado un código a su teléfono" },
                { "T2FA",    "Error de transferencia debido a que no se completó 2FA" },
                { "TR_S",    "Su transferencia fue exitosa" },
                { "TR_NS",   "Su transferencia fue no tiene éxito" },
                { "TR_ALR",  "No se pudo Transferir ya que se alcanzó el límite de cuenta" },
                { "TR_OT1",  "Sólo Transferido £" },
                { "TR_OT2",  "de £" },
                { "TR_T1",   "Transferido: £" },
                { "TR_T2",   "a" },
                { "T_NF",    "Cuenta no encontrada" },
                { "T_SA",    "No se puede transferir a su propia cuenta" },
                { "T_M",     "Por favor, introduzca la cantidad de dinero que desea transferir" },
                { "Misc_C",  "Confirmar" },
                { "T_AN",    "Introduzca el número de cuenta al que desea transferir" },
                { "W_W",     "Retiro: £" },
                { "V_0",     "El valor debe ser superior a £0" },
                { "D_P",     "Para depositar, inserte facturas en la máquina" },
                { "DR_D1",   "Su depósito fue exitoso" },
                { "D_D",     "Depositado: £" },
                { "WR_S",    "Su retiro fue exitoso" },
                { "WR_NS",   "Tu retirada no tuvo éxito" },
                { "WR_W1",   "Retirada: £" },
                { "WR_OW1",  "Solo Retirada: £" },
                { "WR_OW2",  "de £" },
                { "WR_ALR",  "Debido a que se supera el límite de la cuenta" },
                { "R_NB",    "Saldo de cuenta nueva: £" },
                { "WR_P",    "Por favor, recoja su efectivo" },
                { "WR_CNW",  "No se pudo retirar cuando se alcanzó el límite de cuenta" },
                { "Misc_GB", "Volver" },
                { "VA_AN",   "Numero de Cuenta:" },
                { "VA_S",    "Salario Anual:" },
                { "VA_A",    "Edad:" },
                { "VA_B",    "Saldo:" },
                { "VA_C",    "Corriente" },
                { "VA_SM",   "Depósito Simple" },
                { "VA_LTD",  "Depósito Largo Plazo" },
                { "VS_P",    "Su Estado de Cuenta" },
                { "VS_R1",   "Recibido" },
                { "VS_R2",   "De" },
                { "VS_T1",   "Transferido" },
                { "VS_T2",   "a" },
                { "VS_D",    "Depositado" },
                { "VS_W",    "Sacar" },
                { "D",       "Depositar" },
                { "T",       "Transferir" },
                { "MO_EC",   "Expulsar la tarjeta" },
                { "MO_VA",   "Ver Cuenta" },
                { "MO_W",    "Sacar" },
                { "MO_VS",   "Ver Estado de Cuenta" },
                { "P_P",     "Entrada su Pin" },
                { "P_PI",    "Pin Incorrecto, Intentos Restantes:" },
                { "WFC_CS",  "Una tarjeta con el mismo número de tarjeta ha sido tragada, tarjeta no válida" },
                { "WFC_NF",  "Tarjeta no encontrada" },
                { "W_IWA",   "Entrada Cantidad de Retiro" },
                { "T_IA",    "Entrada Cantidad" },
                { "WFC_AF",  "Your Account is Frozen" }
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
