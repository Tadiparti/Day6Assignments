using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6Assignments
{
    interface Interface
    {
        void show(); //contains only declaration
    }
    class MyClass : Interface
    {
        public void show()
        {
            Console.WriteLine("Welcome to IBM!!");
        }

        public static void Main(string[] args)
        {
            MyClass myClass = new MyClass();    

            myClass.show();
        }
    }
}
