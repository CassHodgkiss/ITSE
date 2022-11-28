using ATM.Forms;
using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ATMStates
{
    public class ATMViewStatementState : ATMBaseState
    {
        List<TransactionM> transactions;

        public ATMViewStatementState(ATMForm atmForm) : base(atmForm)
        {
            LangSwitch.OnLangSwitch += () =>
            {
                atmForm.S_Title_L.Text = LangSwitch.GetString("VS_P");
                atmForm.S_Back_L.Text =  LangSwitch.GetString("Misc_GB");
            };
        }

        public override void OnEnterState()
        {
            RefreshTransactions();
            atmForm.ViewStatment_P.Show();

            AudioHandler.PlayAudio("statement");
        }

        public override void OnExitState()
        {
            atmForm.ViewStatment_P.Hide();
        }

        void RefreshTransactions()
        {
            transactions = atmForm.ATM.GetLastTransactions();
            atmForm.Statement_L.Text = "";

            foreach (var item in transactions)
                atmForm.Statement_L.Text += item.FullDetails + "\r\n";
        }

        public override void OnBClicked(int b)
        {
            switch (b)
            {
                case 3: atmForm.SwitchState(atmForm.ATMMainOptionsState); break;
            }
        }
    }
}
