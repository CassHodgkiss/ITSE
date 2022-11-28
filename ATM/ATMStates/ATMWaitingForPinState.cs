using ATM.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ATMStates
{
    public class ATMWaitingForPinState : ATMBaseState
    {
        PictureBox[] pins;

        int tries;
        int pinInputed;
        int[] pinCode;

        ATMCardSwallowedState ATMCardSwallowedState { get; }

        public ATMWaitingForPinState(ATMForm atmForm) : base(atmForm)
        {
            pins = new PictureBox[]
            {
                atmForm.Pin1,
                atmForm.Pin2,
                atmForm.Pin3,
                atmForm.Pin4,
            };

            ATMCardSwallowedState = new ATMCardSwallowedState(atmForm);

            LangSwitch.OnLangSwitch += () =>
            {
                atmForm.WFP_Prompt_L.Text = LangSwitch.GetString("P_P");
            };
        }

        public override void OnEnterState()
        {
            ResetPins();
            atmForm.WFP_Error_L.Text = "";
            atmForm.WaitingForPin_P.Show();

            AudioHandler.PlayAudio("insert_pin");
        }

        public override void OnExitState()
        {
            atmForm.WaitingForPin_P.Hide();
        }

        public override void OnNClicked(int n)
        {
            AddPin(n);
        }

        public override void OnEnterClicked()
        {
            if (pinInputed == 4)
            {
                string pinString = "";
                for (int i = 0; i < 4; i++)
                    pinString += pinCode[i];

                if (atmForm.ATM.PinInput(pinString))
                    OnLogin();
                else
                    PinIncorrect();
            }
        }

        public override void OnBackSpaceClicked()
        {
            if (pinInputed == 0) return;
            pinInputed--;
            pins[pinInputed].Image = Properties.Resources.Pin;
        }

        void AddPin(int pin)
        {
            if (pinInputed == 4) return;

            pinCode[pinInputed] = pin;
            pins[pinInputed].Image = Properties.Resources.PinFilled;
            pinInputed++;
        }

        void PinIncorrect()
        {
            tries++;

            ResetPins();
            if (tries == 3)
            {
                tries = 0;
                atmForm.CardReader.SwallowCard();
                atmForm.SwitchState(atmForm.ATMCardSwallowedState);
            }
            else
            {
                atmForm.WFP_Error_L.Text = LangSwitch.GetString("P_PI") + " " + (3 - tries);
                AudioHandler.PlayAudio("pin_incorrect");
            }
        }

        void OnLogin()
        {
            tries = 0;
            ResetPins();
            atmForm.SwitchState(atmForm.ATMMainOptionsState);
        }

        void ResetPins()
        {
            pinInputed = 0;
            pinCode = new int[4];
            foreach (var pin in pins)
                pin.Image = Properties.Resources.Pin;
        }
    }
}
