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

<<<<<<< HEAD
        static void DoNothing() { 
		// cvhange1
		}
=======
        static void DoNothing() { }

        static void DoNothing2() { }
>>>>>>> stash

        static void DoNothing2() { }
		blah();
    }
}