namespace ATM.Models
{
    public class CreditCardM
    {
        public int Id { get; set; }

        public string CardNumberHash { get; set; }
        public string CreationDate { get; set; }
        public string ExpireDate { get; set; } 
        public string CVV { get; set; }
        public bool IsSwallowed { get; set; }
    }
}
