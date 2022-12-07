namespace ATM.Models
{
    public class TransferM : TransactionM
    {
        public bool IsRecieved { get; set; }

        public AccountM AccountOther { get; set; }

        public override string ToString()
        {
            if (IsRecieved) 
                return 
                    $"{DateCreated} : {LangSwitch.GetString("VS_R1")}  " +
                    $"£{Amount:0.##} {LangSwitch.GetString("VS_R2")} {AccountOther.Id}";         
            else
                return 
                    $"{DateCreated} : {LangSwitch.GetString("VS_T1")} £{Amount:0.##} " +
                    $"{LangSwitch.GetString("VS_T2")} {AccountOther.Id}";
        }
    }
}
