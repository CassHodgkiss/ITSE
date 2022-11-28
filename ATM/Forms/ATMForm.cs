using ATM.ATMStates;
using ATM.Classes;
using ATM.Models;


namespace ATM.Forms
{
    public partial class ATMForm : Form
    {
        Button[] sideButtons;
        Button[] numberButtons;

        public ATM ATM { get; }
        public CardReader CardReader { get; }
        public CashIO CashIO { get; }

        public CreditCards CreditCards { get; }
        public SwallowedCards SwallowedCards { get; }
        public Transactions Transactions { get; }
        public Accounts Accounts { get; }

        ATMBaseState currentState;

        public ATMWaitingForCardState ATMWaitingForCardState { get; }
        public ATMMainOptionsState ATMMainOptionsState { get; }
        public ATMDepositState ATMDepositState { get; }
        public ATMWithdrawState ATMWithdrawState { get; }
        public ATMTransferState ATMTransferState { get; }
        public ATMViewAccountState ATMViewAccountState { get; }
        public ATMViewStatementState ATMViewStatementState { get; }
        public ATMWithdrawAmountState ATMInputWithdrawAmountState { get; }
        public ATMCardSwallowedState ATMCardSwallowedState { get; }
        public ATM2FAState ATM2FAState { get; }
        public ATMWithdrawResultsState ATMWithdrawResultsState { get; }
        public ATMWithdraw2FAFailedState ATMWithdraw2FAFailedState { get; }
        public ATMTransferResultsState ATMTransferResultsState { get; }
        public ATMTransfer2FAFailedState ATMTransfer2FAFailedState { get; }
        public ATMDepositResultsState ATMDepositResults { get; }


        public ATMForm()
        {
            InitializeComponent();

            sideButtons = new Button[]
            {
                B1, B2, B3, B4, B5, B6
            };

            foreach (var b in sideButtons)
                b.Click += new EventHandler(B_Click);

            numberButtons = new Button[]
            {
                N0, N1, N2, N3, N4, N5, N6, N7, N8, N9,
            };

            foreach (var b in numberButtons)
                b.Click += new EventHandler(N_Click);

            CardReader = new CardReader();
            CashIO = new CashIO();
            ATM = new ATM(CardReader, CashIO);
            Accounts = ATM.accounts;

            CreditCards = new CreditCards();
            SwallowedCards = new SwallowedCards();
            Transactions = new Transactions();

            ATMWaitingForCardState = new ATMWaitingForCardState(this);
            ATMMainOptionsState = new ATMMainOptionsState(this);
            ATMDepositState = new ATMDepositState(this);
            ATMTransferState = new ATMTransferState(this);
            ATMViewAccountState = new ATMViewAccountState(this);
            ATMViewStatementState = new ATMViewStatementState(this);
            ATMInputWithdrawAmountState = new ATMWithdrawAmountState(this);
            ATMWithdrawState = new ATMWithdrawState(this);
            ATM2FAState = new ATM2FAState(this);
            ATMWithdrawResultsState = new ATMWithdrawResultsState(this);
            ATMWithdraw2FAFailedState = new ATMWithdraw2FAFailedState(this);
            ATMTransferResultsState = new ATMTransferResultsState(this);
            ATMTransfer2FAFailedState = new ATMTransfer2FAFailedState(this);
            ATMDepositResults = new ATMDepositResultsState(this);
            ATMCardSwallowedState = new ATMCardSwallowedState(this);

            SwitchState(ATMWaitingForCardState);
        }

        public void SwitchState(ATMBaseState newState)
        {
            currentState?.OnExitState();
            currentState = newState;
            currentState.OnEnterState();
        }

        void B_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (b == B1) { currentState.OnBClicked(1); return; }
            if (b == B2) { currentState.OnBClicked(2); return; }
            if (b == B3) { currentState.OnBClicked(3); return; }
            if (b == B4) { currentState.OnBClicked(4); return; }
            if (b == B5) { currentState.OnBClicked(5); return; }
            if (b == B6) { currentState.OnBClicked(6); return; }
        }

        void N_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;

            if (b == N0) { currentState.OnNClicked(0); return; }
            if (b == N1) { currentState.OnNClicked(1); return; }
            if (b == N2) { currentState.OnNClicked(2); return; }
            if (b == N3) { currentState.OnNClicked(3); return; }
            if (b == N4) { currentState.OnNClicked(4); return; }
            if (b == N5) { currentState.OnNClicked(5); return; }
            if (b == N6) { currentState.OnNClicked(6); return; }
            if (b == N7) { currentState.OnNClicked(7); return; }
            if (b == N8) { currentState.OnNClicked(8); return; }
            if (b == N9) { currentState.OnNClicked(9); return; }
        }

        void BackSpace_Click(object sender, EventArgs e) => currentState.OnBackSpaceClicked();

        void Enter_Click(object sender, EventArgs e) => currentState.OnEnterClicked();
    }
}