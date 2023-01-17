using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingCSharp2023.LiskovSubstition.Example2
{
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public virtual int GetArea()
        {
            return Width * Height;
        }
    }

    public class Square : Rectangle
    {
        public override int GetArea()
        {
            return Width * Width;
        }
    }


    // FIX FOR LISKOV RULE
    // 

    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int GetArea()
        {
            return Width * Height;
        }
    }
    public class RectangleFixed : Shape { }

    public class SquareFixed : Shape { }
}
