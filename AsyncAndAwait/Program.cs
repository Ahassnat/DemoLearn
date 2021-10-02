using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    class Program
    {
        static async Task  Main(string[] args)
        {
            var customerName = new List<string>();           
            await Task.Run(() => DownLoadCustomerName(ref customerName));
            DisplayNames(customerName);
            Console.WriteLine("End...");
            Console.ReadLine();
        }
        public static void DownLoadCustomerName(ref List<string> customerName)
        {
            Console.WriteLine("DownLoad ....");
            if (customerName == null)
                customerName = new List<string>();
            for (int i = 0; i < 100; i++)
            {
                customerName.Add($"Name: {i}");
                Thread.Sleep(100);
            }
        }

        private static void DisplayNames(List<string> customerName)
        {
            foreach (var item in customerName)
            {
                Console.WriteLine($"Customer{customerName.FindIndex(str => str == item)} : {item}");
            }
        }
    }
}
