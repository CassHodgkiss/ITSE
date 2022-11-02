using SQLiteDataAccess;
using ATM.Models;


namespace ATM
{
    public class CreditCards // Collection
    {
        List<CreditCardM> cards;

        public CreditCards()
        {
            string sql = @"Select * From CreditCards Where IsSwallowed = 0";
            cards = SQLiteAccess.Read<CreditCardM>(sql, new { });
        }

        // If a CardNumberHash is found, returns true and out the creditCard, else false and null creditCard
        public CreditCardM SearchByCardNumberHash(string cardNumber)
        {
            string cardHash = Hash.GenerateHash(cardNumber);

            CreditCardM creditCard = cards.Find(c => c.CardNumberHash == cardHash);

            return creditCard;
        }

        public void AddCard(CreditCardM creditCard)
        {
            creditCard.IsSwallowed = false;
            cards.Add(creditCard);

            string sql = "Insert Into CreditCards (CardNumberHash, CreationDate, ExpireDate, CVV, IsSwallowed) " +
                "values (@CardNumberHash, @CreationDate, @ExpireDate, @CVV, @IsSwallowed)";
            SQLiteAccess.Write(sql, creditCard);
        }

        public void RemoveCard(CreditCardM creditCard)
        {
            cards.Remove(creditCard);
        }
    }
}
