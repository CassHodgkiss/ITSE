using ATM.Classes;
using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class CardReader
    {
        public event Action OnCardWasSwallowed;
        public event Action OnCardNotFound;
        public event Action OnCardFound;
        public event Action OnCardExpired;

        public CreditCards CreditCards { get; }
        public SwallowedCards SwallowedCards { get; }
        public PhysicalCards PhysicalCards { get; }

        ATM atm;

        public CreditCardM CurrentCreditCard { get; private set; }

        public CardReader()
        {
            CreditCards = new CreditCards();
            SwallowedCards = new SwallowedCards();
            PhysicalCards = new PhysicalCards();
        }

        public void LinkATM(ATM atm)
        {
            this.atm = atm;
        }

        public void CreditCardDetected(string cardNumber)
        {
            CurrentCreditCard = CreditCards.SearchByCardNumberHash(cardNumber);

            if (CurrentCreditCard != null)
            {
                int timeDifference = DateTime.Compare(DateTime.Parse(CurrentCreditCard.ExpireDate), DateTime.Now);
                if(timeDifference <= 0) OnCardExpired?.Invoke();
                else OnCardFound?.Invoke();
                return;
            }
            
            CreditCardM swallowedCard = SwallowedCards.SearchByCardNumberHash(cardNumber);

            if (swallowedCard != null)
                OnCardWasSwallowed?.Invoke();
            else OnCardNotFound?.Invoke();
        }

        public void SwallowCard()
        {
            CreditCards.RemoveCard(CurrentCreditCard);
            SwallowedCards.AddCard(CurrentCreditCard);
        }

        public void EjectCard()
        {
            CurrentCreditCard = null;
        }
    }
}
