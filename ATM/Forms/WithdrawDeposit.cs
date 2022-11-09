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
            InitializeComponent();

            this.mainOptions = mainOptions;
            this.atm = atm;
            this.cashIO = cashIO;

            LanguageSwitcher.OnLangSwitch += SwitchLanguage;
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
            InputBox wDBox = new InputBox(LanguageSwitcher.GetString("WithdrawDeposit_Withdraw_Title"), 
                LanguageSwitcher.GetString("WithdrawDeposit_Withdraw_Prompt"));

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
            InputBox wDBox = new InputBox(LanguageSwitcher.GetString("WithdrawDeposit_Deposit_Title"), 
                LanguageSwitcher.GetString("WithdrawDeposit_Deposit_Prompt"));

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

        void SwitchLanguage()
        {
            Prompt_L.Text =   LanguageSwitcher.GetString("WithdrawDeposit_Prompt");
            Withdraw_B.Text = LanguageSwitcher.GetString("WithdrawDeposit_Withdraw");
            Deposit_B.Text =  LanguageSwitcher.GetString("WithdrawDeposit_Deposit");
            GoBack_B.Text = LanguageSwitcher.GetString("Go_Back");
        }
    }
}
