using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.Models;
using School.Models.Dtos;
using School.Services;

namespace School.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<Student>> GetAllStudents([FromQuery] string? searchWord)
        {
            return _service.GetStudents(searchWord);
        }

        [HttpGet("id")]
        public ActionResult<Student> GetStudent(int id)
        {
            return _service.GetStudent(id);
        }


        [HttpPost]
        public ActionResult<int> CreateStudent(StudentRequestDto student)
        {
            var _student = new Student
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                BirthDate = student.BirthDate,
                CreatedAt = DateTime.UtcNow,
                AddressId = student.AddressId,
            };
           
            _service.AddStudent(_student);
            return Ok(_student.StudentId);
        }

    }
}
