using ATM.ATMStates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM.Forms
{
    public partial class ATMForm : Form
    {
        ATMBaseState currentState;

        public ATMWaitingForCardState ATMWaitingForCardState = new ATMWaitingForCardState();

        public ATMForm()
        {
            InitializeComponent();

            currentState = ATMWaitingForCardState;
        }

        public void SwitchState(ATMBaseState newState)
        {
            currentState.OnExitState(this);
            currentState = newState;
            currentState.OnEnterState(this);
        }

        void B1_Click(object sender, EventArgs e) => currentState.OnB1Clicked(this);
        void B2_Click(object sender, EventArgs e) => currentState.OnB2Clicked(this);
        void B3_Click(object sender, EventArgs e) => currentState.OnB3Clicked(this);
        void B4_Click(object sender, EventArgs e) => currentState.OnB4Clicked(this);
        void B5_Click(object sender, EventArgs e) => currentState.OnB5Clicked(this);
        void B6_Click(object sender, EventArgs e) => currentState.OnB6Clicked(this);
    }
}
