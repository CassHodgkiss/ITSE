using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public static class TwoFA
    {
        public static bool TwoFASim()
        {
            Random rng = new Random();

            int tries = 0;

            string code;
            string returnCode;

            InputBox inputBox = new InputBox(LanguageSwitcher.GetString("TwoFA_2FA_Title"), 
                LanguageSwitcher.GetString("TwoFA_2FA_Prompt"));

            do
            {
                code = "";
                for (int i = 0; i < 6; i++) code += rng.Next(9).ToString();

                MessageBox.Show($"{LanguageSwitcher.GetString("TwoFA_2FA_Phone")} {code}");
                inputBox.ShowDialog();
                returnCode = inputBox.Input_TB.Text;

                if (code == returnCode) return true;

                tries++;
                MessageBox.Show(LanguageSwitcher.GetString("Misc_RemainingTries") + " " + (3 - tries));
                inputBox.Input_TB.Clear();

            } while (tries < 3);

            return false;
        }
    }
}
