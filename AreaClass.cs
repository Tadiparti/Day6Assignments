using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignments
{
   abstract class AreaClass
    {
        abstract public int Area();  //Area as abstract
    }
    class Square : AreaClass
    {
        int side = 0;
        public Square(int n)
        {
            side = n;
        }
        public override int Area()
        {
            return side * side;
        }
    }
    class gfg
    {
        public static void Main()
        {
            Square S = new Square(4);
            Console.WriteLine("Area = " + S.Area());
        }
    }
}
