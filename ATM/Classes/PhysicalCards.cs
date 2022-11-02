using ATM.Models;
using SQLiteDataAccess;

namespace ATM.Classes
{
    public class PhysicalCards
    {
        List<PhysicalCardM> physicalCards = new List<PhysicalCardM>();

        public PhysicalCards()
        {
            string sql = @"Select * From PhysicalCards";
            physicalCards = SQLiteAccess.Read<PhysicalCardM>(sql, new { });
        }

        public List<PhysicalCardM> GetPhysicalCards()
        {
            return physicalCards;
        }
    }
}
