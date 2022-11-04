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
    public partial class Transfer : Form
    {
        MainOptions mainOptions;

        ATM atm;

        AccountM transferTo = null;
        double amount = 0;

        public Transfer(MainOptions mainOptions, ATM atm)
        {
            InitializeComponent();

            this.mainOptions = mainOptions;
            this.atm = atm;

            LanguageSwitcher.OnLangSwitch += SwitchLanguage;
        }

        private void GoBack_B_Click(object sender, EventArgs e)
        {
            mainOptions.Show();
            Hide();
        }

        private void Select_Account_B_Click(object sender, EventArgs e)
        {
            InputBox inputBox = new InputBox(LanguageSwitcher.GetString("Transfer_Account_Title"), 
                LanguageSwitcher.GetString("Transfer_Account_Prompt"));

            inputBox.ShowDialog();
            int id = int.Parse(inputBox.Input_TB.Text);
            transferTo = atm.GetAccountById(id);
            if(transferTo == null)
            {
                MessageBox.Show(LanguageSwitcher.GetString("Transfer_AccountNotFound"));
                return;
            }
            if (transferTo.Id == atm.GetAccount().Id)
            {
                MessageBox.Show(LanguageSwitcher.GetString("Transfer_AccountSame"));
                transferTo = null;
                return;
            }
            MessageBox.Show($"{LanguageSwitcher.GetString("Transfer_AccountFound")} {transferTo.Id}");
            UpdateTransferL();
        }

        private void Select_Amount_B_Click(object sender, EventArgs e)
        {
            InputBox inputBox = new InputBox(LanguageSwitcher.GetString("Transfer_Amount_Title"), 
                LanguageSwitcher.GetString("Transfer_Amount_Prompt"));

            inputBox.ShowDialog();
            amount = double.Parse(inputBox.Input_TB.Text);
            if(amount == 0)
            {
                MessageBox.Show(LanguageSwitcher.GetString("Transfer_AmountZero"));
                return;
            }
            MessageBox.Show($"{LanguageSwitcher.GetString("Transfer_AmountSet")} £{amount}");
            UpdateTransferL();
        }

        private void Transfer_B_Click(object sender, EventArgs e)
        {
            if (transferTo == null) return;
            if (amount == 0) return;

            atm.Transfer(transferTo, amount);
            Reset();
        }

        private void Transfer_B_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible != true) return;

            Reset();
        }

        void UpdateTransferL()
        {
            if (transferTo == null | amount == 0) return;
            Transfer_L.Text = 
                $"{LanguageSwitcher.GetString("Transfer_Transfer_0")} £{amount} " +
                $"{LanguageSwitcher.GetString("Transfer_Transfer_1")} {transferTo.Id}";
        }

        void Reset()
        {
            transferTo = null;
            amount = 0;
            Transfer_L.Text = "";
        }

        void SwitchLanguage()
        {
            Prompt_L.Text =         LanguageSwitcher.GetString("Transfer_Prompt");
            Select_Account_B.Text = LanguageSwitcher.GetString("Transfer_SelectAccount");
            Select_Amount_B.Text =  LanguageSwitcher.GetString("Transfer_SelectAmount");
            Transfer_B.Text =       LanguageSwitcher.GetString("Transfer_Transfer");
            GoBack_B.Text =         LanguageSwitcher.GetString("GoBack");
        }
    }
}
