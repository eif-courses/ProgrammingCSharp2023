using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp2023.OpenClosePrinciple
{
    public abstract class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }

        public abstract void Subscribe(Student std);
    }

    public class OnlineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            //write code to subscribe to an online course
        }
    }

    public class OfflineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            //write code to subscribe to a offline course
        }
    }


    // Student std = new Student(){FirstName="Marius", LastName="Gzegozevskis"}
    // Course onlineSoftwareEngCourse = new OnlineCourse(){Title = "Software Engineering"};
    // onlineSoftwareEngCourse.Suscribe(std);
}
