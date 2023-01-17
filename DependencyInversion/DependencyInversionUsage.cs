using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
namespace ProgrammingCSharp2023.DependencyInversion
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
        private IStudentRepository _stdRepo;
        public Student(IStudentRepository stdRepo)
        {
            _stdRepo = stdRepo;
        }

        public void Save()
        {
            _stdRepo.AddStudent(this);
        }
    }

    public interface IStudentRepository
    {
        void AddStudent(Student std);
        void EditStudent(Student std);
        void DeleteStudent(Student std);

        IList<Student> GetAllStudents();
    }

    public class StudentRepository : IStudentRepository
    {
        public void AddStudent(Student std)
        {
            //code removed for clarity
        }

        public void DeleteStudent(Student std)
        {
            //code removed for clarity
        }

        public void EditStudent(Student std)
        {
            //code removed for clarity
        }

        public IList<Student> GetAllStudents()
        {
            //code removed for clarity
        }
    }
}
