using ProgrammingCSharp2023.SingleResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp2023.OpenClosePrinciple
{

    // If you need add more type off courses then you need write extra If statement which is breaks OCP
    public class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }

        public void Subscribe(Student std)
        {
            Logger.Log("Starting Subscribe()");

            //apply business rules based on the course type live, online, offline, if any 
            if (this.Type == "online")
            {
                //subscribe to online course 
            }
            else if (this.Type == "offline")
            {
                //subscribe to offline course 
            }

            // payment processing
            PaymentManager.ProcessPayment();

            //create CourseRepository class to save student and course into StudentCourse table  

            // send confirmation email
            EmailManager.SendEmail();

            Logger.Log("End Subscribe()");
        }
    }
}
