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
            this.mainOptions = mainOptions;
            this.atm = atm;

            InitializeComponent();
        }

        private void GoBack_B_Click(object sender, EventArgs e)
        {
            mainOptions.Show();
            Hide();
        }

        private void Select_Account_B_Click(object sender, EventArgs e)
        {
            InputBox inputBox = new InputBox("Account", "Input Account Id");
            inputBox.ShowDialog();
            int id = int.Parse(inputBox.Input_TB.Text);
            transferTo = atm.GetAccountById(id);
            if(transferTo == null)
            {
                MessageBox.Show("Account could not be Found");
                return;
            }
            if (transferTo.Id == atm.GetAccount().Id)
            {
                MessageBox.Show("Cannot transfer to Own Account");
                transferTo = null;
                return;
            }
            MessageBox.Show($"Valid Account Found of Id {transferTo.Id}");
            UpdateTransferL();
        }

        private void Select_Amount_B_Click(object sender, EventArgs e)
        {
            InputBox inputBox = new InputBox("Amount", "Input Amount");
            inputBox.ShowDialog();
            amount = double.Parse(inputBox.Input_TB.Text);
            if(amount == 0)
            {
                MessageBox.Show($"Please Insert Amount more than 0");
                return;
            }
            MessageBox.Show($"Set amount to £{amount}");
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
            Transfer_L.Text = $"Transfer £{amount} to Account {transferTo.Id}";
        }

        void Reset()
        {
            transferTo = null;
            amount = 0;
            Transfer_L.Text = "";
        }
    }
}
