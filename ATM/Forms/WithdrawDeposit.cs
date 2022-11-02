using ATM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class WithdrawDeposit : Form
    {
        MainOptions mainOptions;

        ATM atm;
        CashIO cashIO;

        public WithdrawDeposit(MainOptions mainOptions, ATM atm, CashIO cashIO)
        {
            this.mainOptions = mainOptions;
            this.atm = atm;
            this.cashIO = cashIO;

            InitializeComponent();
        }

        void Withdraw(double amount)
        {
            atm.Withdraw(amount);
        }

        void Deposit(double amount)
        {
            cashIO.TakeIn(amount);
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            mainOptions.Show();
            Hide();
        }

        private void Withdraw_Click(object sender, EventArgs e)
        {
            InputBox wDBox = new InputBox("Withdraw", "Input Withdraw Amount");

            while (true)
            {
                wDBox.ShowDialog();
                if(double.TryParse(wDBox.Input_TB.Text, out double result))
                {
                    Withdraw(result);
                    return;
                }
            }
        }

        private void Deposit_Click(object sender, EventArgs e)
        {
            InputBox wDBox = new InputBox("Deposit", "Input Deposit Amount");
            while (true)
            {
                wDBox.ShowDialog();
                if (double.TryParse(wDBox.Input_TB.Text, out double result))
                {
                    Deposit(result);
                    return;
                }
            }
        }

        private void WithdrawDeposit_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == false) return;
            if (atm.GetAccount() is LongTermDepositM) Withdraw_B.Enabled = false;
            else Withdraw_B.Enabled = true;
        }
    }
}
