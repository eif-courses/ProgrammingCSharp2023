using ProgrammingCSharp2023.InterfaceSegregation;
using ProgrammingCSharp2023.SingleResponsibility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProgrammingCSharp2023.SingleResponsibility
{





    //    Holds student's properties such as StudentId, FirstName, LastName, and DoB.
    //Save a new student, or update an existing student to a database.
    //Delete existing students from the database if not subscribed to any course.
    //Apply business rules to subscribe to courses based on the course type.
    //Process the payment for the course.
    //Send confirmation email to a student upon successful registration.
    // Logs each activity to the console.
   
    //If anything in the above responsibility changes, then we will have to modify the Student class. For example, if you need to add a new property then we need to change the Student class.
    //Or, if you need a change in the database, maybe moving from a local server to a cloud, then you need to change the code of the Student class.
    //Or, if you need to change the business rules(validation) before deleting a student or subscribing to a course, or change the logging medium from console to file, then in all these cases you need to change the code of the Student class.
    //Thus, you have many reasons to change the code because it has many responsibilities.
    //SRP tells us to have only one reason to change a class. Let's change the Student class considering SRP where we will keep only one responsibility for the Student class and abstract away (delegate) other responsibilities to other classes.

    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }
        public string email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }

        public void Save()
        {
            Console.WriteLine("Starting Save()");
            //use EF to save student to DB

            Console.WriteLine("End Save()");
        }

        public void Delete()
        {
            Console.WriteLine("Starting Delete()");

            //check if already subscribed courses then don't delete

            Console.WriteLine("End Delete()");
        }

        public IList<Course> Subscribe(Course cs)
        {
            Console.WriteLine("Starting Subscribe()");

            //apply business rules based on the course type 
            if (cs.Type == "online")
            {
                //validate
            }
            else if (cs.type == "live")
            {

            }

            //payment processing code

            //save course subscription to DB

            //send email confirmation code

            Console.WriteLine("End Subscribe()");
        }
    }
}