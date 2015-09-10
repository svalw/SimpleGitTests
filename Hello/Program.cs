using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            //minor change
            Console.WriteLine("Test");
            Console.ReadKey();
        }
        //major change

        static void DoNothing() { 
            this code won't compile
        }

        static void DoNothing2() { }

    }
}
