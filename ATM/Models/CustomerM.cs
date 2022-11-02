namespace ATM.Models
{
    public class CustomerM
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public double AnnualSalary { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public string FullName { get { return $"{FirstName} {LastName}"; } }
    }
}
