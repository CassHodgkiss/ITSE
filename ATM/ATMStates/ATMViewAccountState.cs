using ATM.Forms;
using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.ATMStates
{
    public class ATMViewAccountState : ATMBaseState
    {
        public ATMViewAccountState(ATMForm atmForm) : base(atmForm)
        {
            LangSwitch.OnLangSwitch += () => 
            {
                atmForm.ViewA_Back_L.Text = LangSwitch.GetString("Misc_GB");
            };
        }

        public override void OnEnterState()
        {
            AccountM account = atmForm.ATM.GetAccount();

            atmForm.AccountId_L.Text =       $"{LangSwitch.GetString("VA_AN")} {account.Id}";
            atmForm.CustomerDetails_L.Text = account.Customer.FullName;
            atmForm.CustomerAddress_L.Text = account.Customer.Address;
            atmForm.AnnualSalary_L.Text =    $"{LangSwitch.GetString("VA_S")} £{account.Customer.AnnualSalary}";
            atmForm.Age_L.Text =             $"{LangSwitch.GetString("VA_A")} {account.Customer.Age}";
            atmForm.Balance_L.Text =         $"{LangSwitch.GetString("VA_B")} £{account.Balance:0.##}";

            if(account is CurrentM)
            {
                atmForm.SpecialCustomer_SP.Show();
                atmForm.Overdraft_Prompt_L.Text = LangSwitch.GetString("VA_O");

                if (account.Customer is SpecialCustomerM specialCustomer) atmForm.Overdraft_L.Text = (specialCustomer.OverdraftPercentage * 100) + "%";
                else atmForm.Overdraft_L.Text = "0%";
            }
            else
            {
                atmForm.SpecialCustomer_SP.Hide();
            }

            if (account is CurrentM) atmForm.AccountType_L.Text =              LangSwitch.GetString("VA_C");
            else if (account is SimpleDepositM) atmForm.AccountType_L.Text =   LangSwitch.GetString("VA_SM");
            else if (account is LongTermDepositM) atmForm.AccountType_L.Text = LangSwitch.GetString("VA_LTD");

            atmForm.ViewAccount_P.Show();

            AudioHandler.PlayAudio("account");
        }

        public override void OnExitState()
        {
            atmForm.ViewAccount_P.Hide();
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
