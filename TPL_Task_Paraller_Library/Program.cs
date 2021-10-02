using System;
using System.Threading;
using System.Threading.Tasks;

namespace TPL_Task_Paraller_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            /***First way to TPL*****/
            //Task task1 = new Task(()=> Work(1));
            //Task task2 = new Task(()=> Work(2));
            //task1.Start();

            //task2.Start();

            /*2 way*/
            //Task.Run(() => Work(1)).ContinueWith(x => Console.WriteLine("work Finsh"));
            //Task.Run(() => Work(2)).ContinueWith(x => Console.WriteLine("work Finsh"));


            /*3 way*/
            Task.Factory.StartNew(() => Work(1));
            Task.Factory.StartNew(() => Work(2));
            Console.ReadLine();
        }
        private static void Work(int id)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Id = {id}");
                Thread.Sleep(1000);
            }
        }
    }
}
