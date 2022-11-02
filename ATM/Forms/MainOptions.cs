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
    public partial class MainOptions : Form
    {
        Login login;

        Transfer transfer;
        ViewAccount viewAccount;
        ViewStatement viewStatement;
        WithdrawDeposit withdrawDeposit;

        ATM atm;

        public MainOptions(Login login, ATM atm, CashIO cashIO)
        {
            transfer = new Transfer(this, atm);
            viewAccount = new ViewAccount(this, atm);
            viewStatement = new ViewStatement(this, atm);
            withdrawDeposit = new WithdrawDeposit(this, atm, cashIO);

            this.login = login;

            this.atm = atm;

            InitializeComponent();
        }

        void Logout()
        {
            atm.Logout();

            login.Show();
            Hide();
        }


        private void ViewAccount_Click(object sender, EventArgs e)
        {
            viewAccount.Show();
            Hide();
        }

        private void WithdrawDeposit_Click(object sender, EventArgs e)
        {
            withdrawDeposit.Show();
            Hide();
        }

        private void Transfer_Click(object sender, EventArgs e)
        {
            transfer.Show();
            Hide();
        }

        private void ViewStatement_Click(object sender, EventArgs e)
        {
            viewStatement.Show();
            Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void label1_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == false) return;
            if (atm.GetAccount() is LongTermDepositM) Transfer_B.Enabled = false;
            else Transfer_B.Enabled = true;
        }
    }
}
