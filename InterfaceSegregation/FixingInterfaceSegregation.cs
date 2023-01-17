using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp2023.InterfaceSegregation
{
    public interface IStudentRepositoryFixing
    {
        void AddStudent(Student std);
        void EditStudent(Student std);
        void DeleteStudent(Student std);

        bool SubscribeCourse(Course cs);
        bool UnSubscribeCourse(Course cs);
        IList<Student> GetAllStudents();
        IList<Student> GetAllStudents(Course cs);
    }

    public interface ICourseRepositoryFixing
    {
        void AddCourse(Course cs);
        void EditCourse(Course cs);
        void DeleteCourse(Course cs);

        IList<Course> GetAllCourse();
        IList<Course> GetAllCourses(Student std);
    }
}
