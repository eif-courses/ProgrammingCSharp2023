﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp2023.LiskovSubstition.Example1
{
    public class Bird
    {
        public virtual void Fly()
        {
            Console.WriteLine("I can fly!");
        }

    }
}
