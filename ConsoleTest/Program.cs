using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestLibrary;
using TestLibrary.Computer;
using TestLibrary.Inheritence;
namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Testmessage();

            //Queue();

            //Stack();

            //StackV2();

            //StackV3();

            //QueueV2(); 

            //QueueV3();

            Inheritence();

            Console.ReadLine();
        }

        static void Inheritence()
        {
            GrandFather surya = new GrandFather("Surya");
            Father Chandra = new Father("Chandra", "Jung");
            Uncle Hari = new Uncle("Hari");
            Me Shyam = new Me("Shyam");

            Console.WriteLine("Gran Father Details :");
            Console.WriteLine(surya.FirstName);
            Console.WriteLine(surya.LastName);

            Console.WriteLine("Father's Detail :");
            Console.WriteLine(Chandra.FirstName + " " + Chandra.MiddleName + " " + Chandra.LastName);

            Console.WriteLine("Uncle's Detail :");
            Console.WriteLine(Hari.FirstName + " " + Hari.LastName);

            Console.WriteLine("My Details : ");
            Console.WriteLine(Shyam.FirstName + " " + Shyam.MiddleName + " " + Shyam.LastName);
        }

        static void QueueTemplateFunction()
        {
            QueueTemplateV3<string> strque = new QueueTemplateV3<string>();
            strque.Enqueue("123");

            QueueTemplateV3<int> intque = new QueueTemplateV3<int>();
            //

           
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
            CustomQueue cq = new CustomQueue(20);
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
        static void QueueV2()
        {
            CustomQueueV2 cs = new CustomQueueV2();
            for (int i = 0; i < 20; i++)
            {
                cs.Enqueue(i * 10);
            }

            var tmp = cs.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }

            cs.Dequeue();
            cs.Dequeue();
            Console.WriteLine("After Dequeuing :");
            tmp = cs.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }

            cs.Enqueue(40);
            Console.WriteLine("After Enqueuing 40 : ");
            tmp = cs.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }
        }

        static void QueueV3()
        {
            CustomQueueV3 cs = new CustomQueueV3();
            for (int i = 0; i < 20; i++)
            {
                cs.Enqueue(i * 10);
            }

            foreach (var item in cs.Items)
            {
                Console.WriteLine("Item -> " + item);
            }

            cs.Dequeue();
            cs.Dequeue();
            Console.WriteLine("After Dequeue :");
            foreach (var item in cs.Items)
            {
                Console.WriteLine("Item -> " + item);
            }

            cs.Enqueue(40);
            Console.WriteLine("After Enqueue 40 : ");
            foreach (var item in cs.Items)
            {
                Console.WriteLine("Item -> " + item);
            }
        }
    

    static void Stack()
        {
            CustomStack cs = new CustomStack();
            cs.Push(10);
            
            var tmp = cs.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }

            cs.Pop();
            cs.Pop();
            Console.WriteLine("After Pop :");
            tmp = cs.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }

            cs.Push(40);
            Console.WriteLine("After push 40 : ");
            tmp = cs.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }
        }

        static void StackV2()
        {
            CustomStackV2 cs = new CustomStackV2();
            for (int i = 0; i < 20; i++)
            {
                cs.Push(i * 10);
            }

            var tmp = cs.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }

            cs.Pop();
            cs.Pop();
            Console.WriteLine("After Pop :");
            tmp = cs.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }

            cs.Push(40);
            Console.WriteLine("After push 40 : ");
            tmp = cs.GetItem();
            for (int i = 0; i < tmp.Length; i++)
            {
                Console.WriteLine("Item -> " + tmp[i]);
            }
        }
        static void StackV3()
        {
            CustomStackV3 cs = new CustomStackV3();
            for (int i = 0; i < 20; i++)
            {
                cs.Push(i * 10);
            }

            foreach (var item in cs.Items)
            {
                Console.WriteLine("Item -> " + item);
            }

            cs.Pop();
            cs.Pop();
            Console.WriteLine("After Pop :");
            foreach (var item in cs.Items)
            {
                Console.WriteLine("Item -> " + item);
            }

            cs.Push(40);
            Console.WriteLine("After push 40 : ");
            foreach (var item in cs.Items)
            {
                Console.WriteLine("Item -> " + item);
            }
        }
    }
}










