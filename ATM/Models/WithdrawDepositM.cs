namespace ATM.Models
{
    public class WithdrawDepositM : TransactionM
    {
        public bool IsWithdrawn { get; set; }

        public override string ToString()
        {
            if (IsWithdrawn) return $"{DateCreated} : Withdrew £{Amount}";
            return $"{DateCreated} : Deposited £{Amount}";
        }
    }
}
