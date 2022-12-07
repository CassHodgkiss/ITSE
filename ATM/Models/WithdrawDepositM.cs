namespace ATM.Models
{
    public class WithdrawDepositM : TransactionM
    {
        public bool IsWithdrawn { get; set; }

        public override string ToString()
        {
            if (IsWithdrawn)
                return $"{DateCreated} : {LangSwitch.GetString("VS_W")} £{Amount:0.##}";
            else
                return $"{DateCreated} : {LangSwitch.GetString("VS_D")} £{Amount:0.##}";
        }
    }
}
