using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp2023.Composition
{
    public class Monster
    {
        public string? Name { get; set; }

        public void Attack()
        {
            Console.WriteLine($"Monster: {Name} attacked!");
        }
        public void Walk()
        {
            Console.WriteLine($"Monster: {Name} walked!");

        }
    }
}
