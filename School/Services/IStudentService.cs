using School.Models;

namespace School.Services
{
    public interface IStudentService
    {
        public List<Student> GetStudents();
        public Student GetStudent(int id);
        public int AddStudent(Student student);
        public Student UpdateStudent(int id, Student student);
        public int DeleteStudent(int id);
    }
}
