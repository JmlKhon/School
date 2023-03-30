using Microsoft.EntityFrameworkCore;
using School.Models;

namespace School.Services
{
    public class StudentService : IStudentService
    {
        private readonly SchoolDbContext _context;

        public StudentService(SchoolDbContext context)
        {
            _context = context;
        }
        public List<Student> GetStudents(string? searchWord)
        {
            var students = _context.Students
                .Include(x => x.Address).ToList();

            if (!string.IsNullOrEmpty(searchWord))
            {
                students = students.Where(n => n.FirstName.Contains(searchWord)).ToList();
            }

            return students;
        }

        public Student GetStudent(int id)
        {
            var result = _context.Students.FirstOrDefault(c => c.StudentId == id);

            return result;
        }

        public int AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student.StudentId;
        }

        public Student UpdateStudent(int id, Student student)
        {
            throw new NotImplementedException();
        }

        public int DeleteStudent(int id)
        {
            throw new NotImplementedException();
        }
    }
}
