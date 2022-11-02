namespace ATM.Models
{
    public class TransferM : TransactionM
    {
        public bool IsRecieved { get; set; }

        public AccountM AccountOther { get; set; }

        public override string ToString()
        {
            if(IsRecieved) return $"{DateCreated} : Recieved £{Amount} From {AccountOther.Id}";
            return $"{DateCreated} : Send £{Amount} To {AccountOther.Id}";
        }
    }
}
