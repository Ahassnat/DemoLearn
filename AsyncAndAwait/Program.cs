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
            List<string> customerName;
            customerName = await DownLoadCustomerName();
            DisplayNames(customerName);
            Console.WriteLine("End...");
            Console.ReadLine();
        }
        private static Task<List<string>> DownLoadCustomerName()
        {
            Console.WriteLine("DownLoad ....");
            var customerName = new List<string>();
            for (int i = 0; i < 100; i++)
            {
                customerName.Add($"Name: {i}");
                Thread.Sleep(100);
            }
            return Task.FromResult(customerName);
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
