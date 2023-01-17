using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp2023.DependencyInversion
{

    //    High-level modules should not depend on low-level modules.Both should depend on abstraction

    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }

        //tight coupling
        private StudentRepository _stdRepo = new StudentRepository();

        public Student()
        {

        }

        public void Save()
        {
            _stdRepo.AddStudent(this);
        }
    }

    public class StudentRepository
    {
        public void AddStudent(Student std)
        {
            //EF code removed for clarity
        }

        public void DeleteStudent(Student std)
        {
            //EF code removed for clarity
        }

        public void EditStudent(Student std)
        {
            //EF code removed for clarity
        }

        public IList<Student> GetAllStudents()
        {
            //EF code removed for clarity
        }
    }
}
