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
                    MessageBox.Show(LanguageSwitcher.GetString("CardReader_WasSwallowed"));
                else MessageBox.Show(LanguageSwitcher.GetString("CardReader_NotFound"));

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
            MessageBox.Show(LanguageSwitcher.GetString("CardReader_Eject_Prompt"), LanguageSwitcher.GetString("CardReader_Eject_Title"));
        }
    }
}
