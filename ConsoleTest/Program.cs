using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibrary;
namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Testmessage();
            Console.ReadLine();
        }

        static void Testmessage()
        {
            Test t = new Test();
            Console.WriteLine("From T Object");
           // Console.WriteLine("From Static "+Test.TestFunction());
            Console.WriteLine("From non static "+t.TestNonStatic());
            Test t1 = new Test();

            Console.WriteLine("From t1 object");
            //Console.WriteLine("From Static " + Test.TestFunction());
            Console.WriteLine("From non static " + t1.TestNonStatic());

        }
    }
}
