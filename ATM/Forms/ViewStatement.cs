﻿using ATM.Models;
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
    public partial class ViewStatement : Form
    {
        MainOptions mainOptions;

        ATM atm;

        List<TransactionM> transactions = new List<TransactionM>();

        public ViewStatement(MainOptions mainOptions, ATM atm)
        {
            InitializeComponent();

            this.mainOptions = mainOptions;
            this.atm = atm;

            LanguageSwitcher.OnLangSwitch += SwitchLanguage;
        }

        private void GoBack_Click(object sender, EventArgs e)
        {
            mainOptions.Show();
            Hide();
        }

        void RefreshTransactions()
        {
            transactions = atm.GetLastTransactions();
            Statement_LB.DataSource = null;
            Statement_LB.DataSource = transactions;
            Statement_LB.DisplayMember = "FullDetails";
        }

        private void ViewStatement_VisibleChanged(object sender, EventArgs e)
        {
            if(Visible == true) RefreshTransactions();
        }

        void SwitchLanguage()
        {
            Prompt_L.Text = LanguageSwitcher.GetString("Statement_Prompt");
            GoBack_B.Text = LanguageSwitcher.GetString("Go_Back");
        }
    }
}
