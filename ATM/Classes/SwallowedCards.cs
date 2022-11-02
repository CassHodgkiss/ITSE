using SQLiteDataAccess;
using ATM.Models;

namespace ATM
{
    public class SwallowedCards
    {
        List<CreditCardM> cards;

        public SwallowedCards()
        {      
            string sql = "Select * From CreditCards Where IsSwallowed = 1";
            cards = SQLiteAccess.Read<CreditCardM>(sql, new { });   
        }

        public void AddCard(CreditCardM creditCard)
        {
            creditCard.IsSwallowed = true;
            cards.Add(creditCard);

            string sql = "Update CreditCards Set IsSwallowed = @IsSwallowed Where Id = @Id";
            SQLiteAccess.Write(sql, creditCard);
        }

        public CreditCardM SearchByCardNumberHash(string cardNumber)
        {
            string cardHash = Hash.GenerateHash(cardNumber);

            CreditCardM creditCard = cards.Find(c => c.CardNumberHash == cardHash);

            return creditCard;
        }
    }
}
