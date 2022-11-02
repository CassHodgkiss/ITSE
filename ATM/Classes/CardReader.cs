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
        ATM atm;
        CreditCards creditCards = new CreditCards();
        SwallowedCards swallowedCards = new SwallowedCards();

        public PhysicalCards physicalCards = new PhysicalCards();

        CreditCardM currentCreditCard;


        public void LinkATM(ATM atm)
        {
            this.atm = atm;
        }

        public void CreditCardDetected(string cardNumber)
        {
            currentCreditCard = creditCards.SearchByCardNumberHash(cardNumber);

            if (currentCreditCard == null)
            {
                CreditCardM swallowedCard = swallowedCards.SearchByCardNumberHash(cardNumber);

                if(swallowedCard != null)
                    MessageBox.Show("Card with the same Card Number has been Swallowed, Invalid Card");
                else MessageBox.Show("Credit Card not found");

                return;
            }

            atm.CreditCardScanned(currentCreditCard);
        }

        public void SwallowCard()
        {
            creditCards.RemoveCard(currentCreditCard);
            swallowedCards.AddCard(currentCreditCard);
        }

        public void EjectCard()
        {
            currentCreditCard = null;
            MessageBox.Show("Card Ejected", "CardReader");
        }
    }
}
