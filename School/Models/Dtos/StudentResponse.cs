namespace School.Models.Dtos
{
    public class StudentResponseDto
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public Address Address { get; set; }
    }
}
