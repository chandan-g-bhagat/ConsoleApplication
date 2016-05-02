using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibrary;
using TestLibrary.Computer;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testmessage();

            Queue();
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

        static void Queue()
        {
            CustomQueue cq = new CustomQueue();
            cq.Enqueue(10);
            cq.Enqueue(20);
            cq.Enqueue(30);

            Console.WriteLine(cq.Count);
            var tmp = cq.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }

            cq.Dequeue();
            Console.WriteLine("After Dequeuing : ");
            tmp = cq.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }

            cq.Enqueue(40);
            Console.WriteLine("After adding 40 : ");
            tmp = cq.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }
        }
    }
}










