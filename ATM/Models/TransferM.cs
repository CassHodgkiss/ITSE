namespace ATM.Models
{
    public class TransferM : TransactionM
    {
        public bool IsRecieved { get; set; }

        public AccountM AccountOther { get; set; }

        public override string ToString()
        {
            if (IsRecieved) return $"{DateCreated} : {LanguageSwitcher.GetString("TransferM_Recieved_0")}  " +
                                   $"£{Amount} {LanguageSwitcher.GetString("TransferM_Recieved_1")} {AccountOther.Id}";         
            return $"{DateCreated} : {LanguageSwitcher.GetString("TransferM_Send_0")} £{Amount} " +
                   $"{LanguageSwitcher.GetString("TransferM_Send_1")} {AccountOther.Id}";
        }
    }
}
