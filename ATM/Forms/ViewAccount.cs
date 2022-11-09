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
    public partial class ViewAccount : Form
    {
        MainOptions mainOptions;

        ATM atm;

        AccountM account;

        public ViewAccount(MainOptions mainOptions, ATM atm)
        {
            InitializeComponent();

            this.mainOptions = mainOptions;
            this.atm = atm;

            LanguageSwitcher.OnLangSwitch += SwitchLangauge;
        }

        private void GoBack_B_Click(object sender, EventArgs e)
        {
            mainOptions.Show();
            Hide();
        }

        private void ViewAccount_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == false) return;

            account = atm.GetAccount();
            SetAccountTypeLabel();

            AccountId_L.Text = $"{LanguageSwitcher.GetString("ViewAccount_Account")} {account.Id}";
            CustomerDetails_L.Text = account.Customer.FullName;
            CustomerAddress_L.Text = account.Customer.Address;
            AnnualSalary_L.Text = $"{LanguageSwitcher.GetString("ViewAccount_Salary")} £{account.Customer.AnnualSalary}";
            Age_L.Text = $"{LanguageSwitcher.GetString("ViewAccount_Age")} {account.Customer.Age}";

            Balance_L.Text = $"{LanguageSwitcher.GetString("ViewAccount_Balance")} £{account.Balance}";
        }

        void SetAccountTypeLabel()
        {
            if      (account is CurrentM) AccountType_L.Text = LanguageSwitcher.GetString("ViewAccount_C");
            else if (account is SimpleDepositM) AccountType_L.Text = LanguageSwitcher.GetString("ViewAccount_SM");
            else if (account is LongTermDepositM) AccountType_L.Text = LanguageSwitcher.GetString("ViewAccount_LTD");
        }

        void SwitchLangauge()
        {
            GoBack_B.Text = LanguageSwitcher.GetString("Go_Back");
        }
    }
}
