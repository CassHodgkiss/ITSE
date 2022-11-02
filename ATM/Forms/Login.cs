using SQLiteDataAccess;
using ATM.Models;
using ATM.Classes;

namespace ATM
{
    public partial class Login : Form
    {
        MainOptions mainOptions;

        ATM atm;
        CardReader cardReader;
        CashIO cashIO;

        List<PhysicalCardM> physicalCardList;

        public Login()
        {
            InitializeComponent();

            cardReader = new CardReader();

            //TempCreateData();
            physicalCardList = cardReader.physicalCards.GetPhysicalCards();
            RefreshCardList();

            cashIO = new CashIO();

            atm = new ATM(cardReader, cashIO);

            mainOptions = new MainOptions(this, atm, cashIO);

            atm.OnLogin += LoginSignal;
        }

        void InsertCreditCard(string cardNumber)
        {
            cardReader.CreditCardDetected(cardNumber);
        }

        void LoginSignal()
        {
            mainOptions.Show();
            Hide();
        }

        void RefreshCardList()
        {          
            physicalCardList = cardReader.physicalCards.GetPhysicalCards();
            Card_LB.DataSource = null;
            Card_LB.DataSource = physicalCardList;
            Card_LB.DisplayMember = "CardNumber";
        }

        private void EnterCard_B_Click(object sender, EventArgs e)
        {
            string cardNumber = physicalCardList[Card_LB.SelectedIndex].CardNumber;

            InsertCreditCard(cardNumber);
            RefreshCardList();
        }

        Random rng = new Random();
        private void TempCreateData()
        {
            string pins = "";

            for (int i = 0; i < 50; i++)
            {
                string info = "";

                //Customer

                int annualSalary = rng.Next(10000, 60000);

                CustomerM customer;

                if (annualSalary >= 30000)
                {
                    customer = new SpecialCustomerM()
                    {
                        FirstName = "firstname",
                        LastName = "lastname",
                        Address = "fake address " + rng.Next(0, 99),
                        AnnualSalary = annualSalary,
                        Age = rng.Next(18, 70),
                        OverdraftPercentage = 0.1,
                    };
                }
                else
                {
                    customer = new CustomerM()
                    {
                        FirstName = "firstname",
                        LastName = "lastname",
                        Address = "fake address " + rng.Next(0, 99),
                        AnnualSalary = annualSalary,
                        Age = rng.Next(18, 70),
                    };
                }

                string sqlU = "Insert Into Customers (FirstName, LastName, Address, AnnualSalary, Age) " +
                              "values (@FirstName, @LastName, @Address, @AnnualSalary, @Age)";
                customer.Id = SQLiteAccess.WriteReturnPk(sqlU, customer);

                if(customer is SpecialCustomerM specialCustomer)
                {
                    string sqlSC = "Insert Into SpecialCustomers (CustomerId, OverdraftPercentage) values (@Id, @OverdraftPercentage)";
                    SQLiteAccess.Write(sqlSC, specialCustomer);
                }


                //Credit Card

                string cardNumber = "";
                for (int y = 0; y < 16; y++) cardNumber += rng.Next(9).ToString();

                string cvv = "";
                for (int y = 0; y < 4; y++) cvv += rng.Next(9).ToString();

                CreditCardM card = new CreditCardM()
                {
                    CardNumberHash = Hash.GenerateHash(cardNumber),
                    CreationDate = DateTime.Now.ToString(),
                    ExpireDate = DateTime.Now.AddYears(5).ToString(),
                    CVV = cvv,
                    IsSwallowed = false
                };

                string sqlC = "Insert Into CreditCards (CardNumberHash, CreationDate, ExpireDate, CVV, IsSwallowed) " +
                              "values (@CardNumberHash, @CreationDate, @ExpireDate, @CVV, @IsSwallowed)";
                card.Id = SQLiteAccess.WriteReturnPk(sqlC, card);


                //Account

                string pin = "";
                for (int j = 0; j < 4; j++) pin += rng.Next(10).ToString();

                AccountM account;

                switch (rng.Next(3))
                {
                    case 0:
                        info += "C   | ";
                        account = new CurrentM()
                        {
                            Balance = rng.Next(100, 100000),
                            IsFrozen = false,
                            PinHash = Hash.GenerateHash(pin),
                            CreditCard = card,
                            Customer = customer,
                        };
                        break;
                    case 1:
                        info += "SD  | ";
                        account = new SimpleDepositM()
                        {
                            Balance = rng.Next(100, 100000),
                            IsFrozen = false,
                            PinHash = Hash.GenerateHash(pin.ToString()),
                            CreditCard = card,
                            Customer = customer,
                        };
                        break;
                    case 2:
                        info += "LTD | ";
                        account = new LongTermDepositM()
                        {
                            Balance = rng.Next(100, 100000),
                            IsFrozen = false,
                            PinHash = Hash.GenerateHash(pin.ToString()),
                            CreditCard = card,
                            Customer = customer,
                        };
                        break;
                    default: account = new AccountM(); break;
                }

                string sqlA = "Insert Into Accounts (Balance, PinHash, IsFrozen, CreditCardId, CustomerId) " +
                              "values (@Balance, @PinHash, @IsFrozen, @CreditCardId, @CustomerId)";

                var accountTemp = new
                {
                    account.Balance,
                    account.PinHash,
                    account.IsFrozen,
                    CreditCardId = account.CreditCard.Id,
                    CustomerId = account.Customer.Id
                };

                account.Id = SQLiteAccess.WriteReturnPk(sqlA, accountTemp);


                if(account is CurrentM current)
                {
                    string sqlCurrent = "Insert Into Currents (AccountId) values (@Id)";
                    SQLiteAccess.Write(sqlCurrent, current);
                }
                else if(account is SimpleDepositM simple)
                {
                    string sqlSimple = "Insert Into SimpleDeposits (AccountId) values (@Id)";
                    SQLiteAccess.Write(sqlSimple, simple);
                }
                else if(account is LongTermDepositM longTerm)
                {
                    string sqlLongTerm = "Insert Into LongTermDeposits (AccountId) values (@Id)";
                    SQLiteAccess.Write(sqlLongTerm, longTerm);
                }


                //Physical Cards

                PhysicalCardM physicalCard = new PhysicalCardM()
                {
                    CardNumber = cardNumber,
                };

                string sqlPC = "Insert Into PhysicalCards (CardNumber) values (@CardNumber)";
                SQLiteAccess.Write(sqlPC, physicalCard);

                info += $"CardId : {cardNumber} | Pin : {pin}\n";
                pins += info;
            }

            File.WriteAllText("pins.txt", pins);
        }
    }
}