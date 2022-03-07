using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignments
{
    class AccessSpecifier
    {
        public class ABC
        {
            protected int Id;
        }
        public class DEF : ABC
        {
            public void Print()
            {
                Id = 2;
                Console.WriteLine(Id);
            }
        }
        public class Program
        {
            public static void Main(string[] args)
            {
                DEF def=new DEF();
                def.Print();
                Console.ReadLine();
            }
        }
    }
}
