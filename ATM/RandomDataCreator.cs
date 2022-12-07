using ATM.Models;
using SQLiteDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public static class RandomDataCreator // DEBUG | Creates new Random Customer Data
    {
        static Random rng = new Random();

        public static void CreateData()
        {
            string filePath = @"C:\Users\Cajcr\OneDrive - Sheffield Hallam University\sheffield_hallam\year_2\S1\introduction_to_software_engineering\Assessment\ATM\ATM\Data\ATMData.db";
            string emptyFilePath = @"C:\Users\Cajcr\OneDrive - Sheffield Hallam University\sheffield_hallam\year_2\S1\introduction_to_software_engineering\Assessment\ATM\ATM\Data\ATMData_Empty.db";
            File.Delete(filePath);
            File.Copy(emptyFilePath, filePath);

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

                info += $"{customer.Id}";

                if (customer is SpecialCustomerM specialCustomer)
                {
                    string sqlSC = "Insert Into SpecialCustomers (CustomerId, OverdraftPercentage) values (@Id, @OverdraftPercentage)";
                    SQLiteAccess.Write(sqlSC, specialCustomer);
                }

                bool hasC = rng.Next(2) == 1;
                bool hasSD = rng.Next(2) == 1;
                bool hasLTD = rng.Next(2) == 1;

                int amount = (hasC ? 1 : 0) + (hasSD ? 1 : 0) + (hasLTD ? 1 : 0);

                if(amount == 0)
                {
                    amount = 1;
                    int value = rng.Next(3);
                    switch (value)
                    {
                        case 0: hasC = true; break;
                        case 1: hasSD = true; break;
                        case 2: hasLTD = true; break;
                    }
                }

                //Credit Cards

                CreditCardM[] cards = new CreditCardM[amount];
                string[] cardNumbers = new string[amount];

                for (int j = 0; j < amount; j++)
                {
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

                    cards[j] = card;
                    cardNumbers[j] = cardNumber;
                }

                string[] pinNumbers = new string[amount];

                int cardIndex = 0;

                if (hasC)
                {
                    string pin = "";
                    for (int j = 0; j < 4; j++) pin += rng.Next(10).ToString();
                    pinNumbers[cardIndex] = pin;

                    info += $" | C   | {cardNumbers[cardIndex]} | Pin : {pin}";

                    var current = new CurrentM()
                    {
                        Balance = rng.Next(100, 100000),
                        IsFrozen = false,
                        PinHash = Hash.GenerateHash(pin),
                        CreditCard = cards[cardIndex++],
                        Customer = customer,
                    };

                    var accountTemp = new
                    {
                        current.Balance,
                        current.PinHash,
                        current.IsFrozen,
                        CreditCardId = current.CreditCard.Id,
                        CustomerId = current.Customer.Id
                    };

                    string sqlA = "Insert Into Accounts (Balance, PinHash, IsFrozen, CreditCardId, CustomerId) " +
                                  "values (@Balance, @PinHash, @IsFrozen, @CreditCardId, @CustomerId)";
                    current.Id = SQLiteAccess.WriteReturnPk(sqlA, accountTemp);

                    string sqlCurrent = "Insert Into Currents (AccountId) values (@Id)";
                    SQLiteAccess.Write(sqlCurrent, current);
                }
                if (hasSD)
                {
                    string pin = "";
                    for (int j = 0; j < 4; j++) pin += rng.Next(10).ToString();
                    pinNumbers[cardIndex] = pin;

                    info += $" | SD  | {cardNumbers[cardIndex]} | Pin : {pin}";

                    var simpleDeposit = new SimpleDepositM()
                    {
                        Balance = rng.Next(100, 100000),
                        IsFrozen = false,
                        PinHash = Hash.GenerateHash(pin.ToString()),
                        CreditCard = cards[cardIndex++],
                        Customer = customer,
                    };

                    var accountTemp = new
                    {
                        simpleDeposit.Balance,
                        simpleDeposit.PinHash,
                        simpleDeposit.IsFrozen,
                        CreditCardId = simpleDeposit.CreditCard.Id,
                        CustomerId = simpleDeposit.Customer.Id
                    };

                    string sqlA = "Insert Into Accounts (Balance, PinHash, IsFrozen, CreditCardId, CustomerId) " +
                                   "values (@Balance, @PinHash, @IsFrozen, @CreditCardId, @CustomerId)";
                    simpleDeposit.Id = SQLiteAccess.WriteReturnPk(sqlA, accountTemp);

                    string sqlSimple = "Insert Into SimpleDeposits (AccountId) values (@Id)";
                    SQLiteAccess.Write(sqlSimple, simpleDeposit);
                }
                if (hasLTD)
                {
                    string pin = "";
                    for (int j = 0; j < 4; j++) pin += rng.Next(10).ToString();
                    pinNumbers[cardIndex] = pin;

                    info += $" | LTD | {cardNumbers[cardIndex]} | Pin : {pin}";

                    var longTermDeposit = new LongTermDepositM()
                    {
                        Balance = rng.Next(100, 100000),
                        IsFrozen = false,
                        PinHash = Hash.GenerateHash(pin.ToString()),
                        CreditCard = cards[cardIndex++],
                        Customer = customer,
                    };

                    var accountTemp = new
                    {
                        longTermDeposit.Balance,
                        longTermDeposit.PinHash,
                        longTermDeposit.IsFrozen,
                        CreditCardId = longTermDeposit.CreditCard.Id,
                        CustomerId = longTermDeposit.Customer.Id
                    };

                    string sqlA = "Insert Into Accounts (Balance, PinHash, IsFrozen, CreditCardId, CustomerId) " +
                                   "values (@Balance, @PinHash, @IsFrozen, @CreditCardId, @CustomerId)";
                    longTermDeposit.Id = SQLiteAccess.WriteReturnPk(sqlA, accountTemp);

                    string sqlLongTerm = "Insert Into LongTermDeposits (AccountId) values (@Id)";
                    SQLiteAccess.Write(sqlLongTerm, longTermDeposit);
                }

                //Physical Cards
                
                for (int j = 0; j < amount; j++)
                {
                    var cardNumber = cardNumbers[j];
                    var pin = pinNumbers[j];
                
                    PhysicalCardM physicalCard = new PhysicalCardM()
                    {
                        CardNumber = cardNumber,
                    };
                
                    string sqlPC = "Insert Into PhysicalCards (CardNumber) values (@CardNumber)";
                    SQLiteAccess.Write(sqlPC, physicalCard);
                }

                pins += info + "\n";
            }

            File.WriteAllText("pins.txt", pins);
        }
    }
}
