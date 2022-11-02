namespace ATM.Models
{
    public class TransactionM
    {
        public int Id { get; set; }

        public string DateCreated { get; set; }
        public double Amount { get; set; }

        public AccountM Account { get; set; }

        public string FullDetails { get { return ToString(); } }
    }
}
