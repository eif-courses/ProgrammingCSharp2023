using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp2023.Composition
{
    public class FlyingMonster : Monster 
    {
        public void Fly()
        {
            Console.WriteLine($"Monster {Name} flew!");
        }
    }
}
