using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp2023.LiskovSubstition.Example1
{
    public class Penguin : Bird
    {
        public override void Fly()
        {
            throw new Exception("I can't fly!!!");
        }
        public void Swim()
        {
            Console.WriteLine("I Can Swim");
        }
    }
}
