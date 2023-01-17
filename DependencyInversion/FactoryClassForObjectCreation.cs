using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp2023.DependencyInversion
{

    // Instead of creating manually, you can use the factory class to create it,
    // so that all the object creation will be in one place.

    // Its recommended to use Dependency Injection and IoC containers
    // for creating and passing objects of low-level classes to high-level classes.


    public class RepositoryFactory
    {
        public static IStudentRepository GetStudentRepository()
        {
            return new StudentRepository();
        }

        public static IStudentRepository GetTestStudentRepository()
        {
            return new TestStudentRepository();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            //for production
            Student std1 = new Student(RepositoryFactory.GetStudentRepository());

            //for unit test
            Student std2 = new Student(RepositoryFactory.TestGetStudentRepository());
        }
    }
}
