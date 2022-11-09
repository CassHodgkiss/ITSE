namespace ATM.Models
{
    public class WithdrawDepositM : TransactionM
    {
        public bool IsWithdrawn { get; set; }

        public override string ToString()
        {
            if (IsWithdrawn)
                return $"{DateCreated} : {LanguageSwitcher.GetString("WithdrawDepositM_Withdrew")} £{Amount}";
            else
                return $"{DateCreated} : {LanguageSwitcher.GetString("WithdrawDepositM_Deposited")} £{Amount}";
        }
    }
}
