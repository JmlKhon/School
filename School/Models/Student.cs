namespace School.Models
{
    public class Student : BaseEntity
    {
        public int StudentId { get; set; }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public int AddressId { get; set; }

        public Address Address { get; set; }
    }
}
