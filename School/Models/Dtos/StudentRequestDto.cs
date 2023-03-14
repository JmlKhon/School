namespace School.Models.Dtos
{
    public class StudentRequestDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public int AddressId { get; set; }
    }
}
