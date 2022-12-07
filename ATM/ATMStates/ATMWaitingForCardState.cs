using ATM.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ATMStates
{
    public class ATMWaitingForCardState : ATMBaseState
    {
        public ATMWaitingForPinState ATMWaitingForPinState { get; }

        public ATMWaitingForCardState(ATMForm atmForm) : base(atmForm)
        {
            atmForm.CardReader.OnCardWasSwallowed += CardWasSwallowed;
            atmForm.CardReader.OnCardNotFound += CardNotFound;
            atmForm.CardReader.OnCardFound += CardFound;
            atmForm.CardReader.OnCardExpired += CardExpired;
            atmForm.ATM.OnAccountFrozen += AccountFrozen;
            atmForm.ATM.OnAccountFound += AccountFound;
            atmForm.ATM.OnAccountNotFound += AccountNotFound;

            ATMWaitingForPinState = new ATMWaitingForPinState(atmForm);

            LangSwitch.OnLangSwitch += () =>
            {
                atmForm.CI_Prompt_L.Text = LangSwitch.GetString("WFC_P");
            };
        }

        public override void OnEnterState()
        {
            atmForm.CI_Error_L.Text = "";
            atmForm.WaitingForCard_P.Show();
        }

        public override void OnExitState()
        {
            atmForm.WaitingForCard_P.Hide();
        }

        public override void OnBClicked(int b)
        {
            switch (b)
            {
                case 3: LangSwitch.SwitchLanguage("en"); return;
                case 6: LangSwitch.SwitchLanguage("es"); return;
            }
        }

        public override void OnEnterClicked()
        {
            var form = new InsertCardSim(atmForm.CardReader);
            form.ShowDialog();
            string cardNumber = form.GetCardNumber();

            atmForm.CardReader.CreditCardDetected(cardNumber);
        }

        void CardFound()
        {
            atmForm.ATM.CreditCardScanned();
        }

        void CardNotFound()
        {
            atmForm.CI_Error_L.Text = LangSwitch.GetString("WFC_NF");
        }                                                  

        void CardWasSwallowed()
        {
            atmForm.CI_Error_L.Text = LangSwitch.GetString("WFC_CS");
        }

        void AccountFrozen()
        {
            atmForm.CI_Error_L.Text = LangSwitch.GetString("WFC_AF");
        }

        void AccountFound()
        {
            atmForm.SwitchState(ATMWaitingForPinState);
        }

        void AccountNotFound()
        {
            atmForm.CI_Error_L.Text = LangSwitch.GetString("T_NF");
        }

        void CardExpired()
        {
            atmForm.CI_Error_L.Text = LangSwitch.GetString("WFC_CE");
        }
    }
}
