using SQLiteDataAccess;
using ATM.Models;
using ATM.Classes;

namespace ATM.Forms
{
    public partial class InsertCardSim : Form
    {
        List<PhysicalCardM> physicalCardList;
        List<PhysicalCardM> doesntExitCardList;
        CardReader cardReader;

        string selectedCard;

        public InsertCardSim(CardReader cardReader)
        {
            InitializeComponent();
            this.cardReader = cardReader;
            Setup();
        }

        public string GetCardNumber()
        {
            return selectedCard;
        }

        void Setup()
        {
            physicalCardList = cardReader.PhysicalCards.GetPhysicalCards();

            doesntExitCardList = new List<PhysicalCardM>()
            {
                new PhysicalCardM() { CardNumber = "34345656343435656" },
                new PhysicalCardM() { CardNumber = "56576764546757645" },
                new PhysicalCardM() { CardNumber = "78354665736324656" },
                new PhysicalCardM() { CardNumber = "37326546657656546" },
            };

            RefreshCardList();
        }

        void RefreshCardList()
        {
            physicalCardList = cardReader.PhysicalCards.GetPhysicalCards();
            Card_LB.DataSource = null;
            Card_LB.DataSource = physicalCardList;
            Card_LB.DisplayMember = "CardNumber";

            DoesntExist_LB.DataSource = null;
            DoesntExist_LB.DataSource = doesntExitCardList;
            DoesntExist_LB.DisplayMember = "CardNumber";
        }

        private void EnterCard_B_Click(object sender, EventArgs e)
        {
            selectedCard = physicalCardList[Card_LB.SelectedIndex].CardNumber;

            Hide();
        }

        private void Enter_DE_B_Click(object sender, EventArgs e)
        {
            selectedCard = doesntExitCardList[DoesntExist_LB.SelectedIndex].CardNumber;

            Hide();
        }
    }
}