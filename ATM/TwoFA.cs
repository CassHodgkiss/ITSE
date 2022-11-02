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

            InputBox inputBox = new InputBox("2FA Code", "Input Your Code Here:");

            do
            {
                code = "";
                for (int i = 0; i < 6; i++) code += rng.Next(9).ToString();

                MessageBox.Show($"Phone Notification Sim:\nYour code is {code}");
                inputBox.ShowDialog();
                returnCode = inputBox.Input_TB.Text;

                if (code == returnCode) return true;

                tries++;
                MessageBox.Show("Remaining Tries: " + (3 - tries));
                inputBox.Input_TB.Clear();

            } while (tries < 3);

            return false;
        }
    }
}
