using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp2023.Composition
{
    public class SwimmingMonster : Monster
    {
        public void Swim()
        {
            Console.WriteLine($"Monster {Name} swam!");
        }
    }
}
