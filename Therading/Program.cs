using System;
using System.Threading;

namespace Therading
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.Name = "Main Thread";
            Console.WriteLine($"Begin thread \"{Thread.CurrentThread.Name}\"");
            Thread threadObj1 = new Thread(Thread1);
            threadObj1.Name = "First Thread";
            Thread threadObj2 = new Thread(Thread2);
            threadObj2.Name = "Secend Thread";
            
            threadObj1.Start();
            threadObj2.Start();

            Console.WriteLine($"End thread \"{Thread.CurrentThread.Name}\"");
        }
        static void Thread1()
        {
            Console.WriteLine($"Begin thread \"{Thread.CurrentThread.Name}\"");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Function 1:Begin thread \"{Thread.CurrentThread.Name}\":  {i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"End thread \"{Thread.CurrentThread.Name}\"");
        }
        static void Thread2()
        {
            Console.WriteLine($"Begin thread \"{Thread.CurrentThread.Name}\"");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Function 2:Begin thread \"{Thread.CurrentThread.Name}\":  {i}");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"End thread \"{Thread.CurrentThread.Name}\"");
        }
    }
}
