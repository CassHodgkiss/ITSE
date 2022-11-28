using ATM.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ATMStates
{
    public class ATM2FAState : ATMBaseState
    {
        //Functions to return to after 2fa passed or failed
        Action passed;
        Action failed;

        PictureBox[] pins;

        int tries;
        int pinInputed;
        int[] pinCode;

        string code;

        public ATM2FAState(ATMForm atmForm) : base(atmForm)
        {
            pins = new PictureBox[]
            {
                atmForm.TwoP1,
                atmForm.TwoP2,
                atmForm.TwoP3,
                atmForm.TwoP4,
                atmForm.TwoP5,
                atmForm.TwoP6,
            };

            LangSwitch.OnLangSwitch += () =>
            {
                atmForm.TwoFA_Prompt_L.Text = LangSwitch.GetString("2FA");
            };
        }

        public override void OnEnterState()
        {
            Random rng = new Random();

            code = "";
            for (int i = 0; i < 6; i++) code += rng.Next(9).ToString();

            ResetPins();
            atmForm.TwoFA_Error_L.Text = "";
            atmForm.TwoFA_P.Show();

            MessageBox.Show(code);
        }

        public override void OnExitState()
        {
            ResetPins();
            atmForm.TwoFA_Error_L.Text = "";
            atmForm.TwoFA_P.Hide();
        }

        public override void OnNClicked(int n)
        {
            AddPin(n);
        }

        public override void OnEnterClicked()
        {
            if (pinInputed == 6)
            {
                string pinString = "";
                for (int i = 0; i < 6; i++)
                    pinString += pinCode[i];

                if (CheckCode(pinString))
                    OnPassed();
                else
                    OnFailed();
            }
        }

        bool CheckCode(string pinString)
        {
            return code == pinString;
        }

        public override void OnBackSpaceClicked()
        {
            if (pinInputed == 0) return;
            pinInputed--;
            pins[pinInputed].Image = Properties.Resources.Pin;
        }

        void AddPin(int pin)
        {
            if (pinInputed == 6) return;

            pinCode[pinInputed] = pin;
            pins[pinInputed].Image = Properties.Resources.PinFilled;
            pinInputed++;
        }

        void OnFailed()
        {
            tries++;

            ResetPins();
            if (tries == 3)
            {
                tries = 0;
                failed();
                OnExitState();
            }
            else
            {
                atmForm.TwoFA_Error_L.Text = LangSwitch.GetString("P_PI") + " " + (3 - tries);
            }
        }

        void OnPassed()
        {
            tries = 0;
            ResetPins();
            passed();
        }

        void ResetPins()
        {
            pinInputed = 0;
            pinCode = new int[6];
            foreach (var pin in pins)
                pin.Image = Properties.Resources.Pin;
        }

        public void SetReturnFunctions(Action passed, Action failed)
        {
            this.passed = passed;
            this.failed = failed;
        }
    }
}
