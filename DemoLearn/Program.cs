using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DemoLearn
{


    public class A
    {
        public readonly string name = "A";
        public A()
        {
            name = "B";
        }
        public A( string c)
        {
            name = c;
        }
    }
    class KeyValuePair<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
    }

    class DataStore<T>
    {
        public T Data { get; set; }
        private T[] _data = new T[10];

        public void AddOrUpdate(int index, T item)
        {
            if (index >= 0 && index < 10)
                Console.WriteLine(_data[index] = item); 
        
        }

        public T GetData(int index)
        {
            if (index >= 0 && index < 10)
                return _data[index];
            else
                return default(T);
        }

    }
    class Printer
    {
        public void Print<T>(T data)
        {
            Console.WriteLine(data);
        }
    }
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
        public Address Address { get; set; }
        public static int count = 0;

        public Student(string Name, int Age, string Country, Address Address)
        {
            this.Name = Name;
            this.Age = Age;
            this.Country = Country;
            this.Address = Address;
            count++;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Name: " +" "+ Name +" "+
                              "Age: " + " " + Age + " " +
                              "Country: " + " " + Country + " " +
                              "Addres: " + " " + Address.StrName + " "+ Address.StrNo);
        }
    }
    class Address
    {
        public int StrNo { get; set; }
        public string StrName { get; set; }
        public Address(int StrNo, string StrName)
        {
            this.StrNo = StrNo;
            this.StrName = StrName;
        }
    }

    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class DataMigrator
    {
        // we need a new instance of
        // a Logger object to create
        // an association with the
        // Logger class
        Logger logger = new Logger();

        public void Migrate()
        {
            logger.Log("Migrating...");
        }
    }
    public delegate int MyDelegate();
    

    public delegate T add<T>(T param1,T param2);
    class Program
    {

        class ClassA
        {
            static int MethodA()
            {
                return 100;
            }
        }
        class ClassB
        {
            static int MethodB()
            {
                return 200;
            }
        }
        public static int Sum(int val1, int val2)
        {
            return val1 + val2;
        }

        public static string Concat(string str1, string str2)
        {
            return str1 + str2;
        }
        // function to pass by Delegate
        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
        public delegate void DelegateForHelloFunction(string message);

      
        static void Main(string[] args)
        {

            

            //DelegateForHelloFunction del = new DelegateForHelloFunction(Hello);
            //del("Hellow From Delegate");

            //add<int> sum = Sum;
            //Console.WriteLine(sum(10,20));
            //add<string> str = Concat;
            //Console.WriteLine(str("Abd","Hass"));

            
            #region test
            /**********************Has a Relation Composite***********************/
            //DataMigrator DataMig = new DataMigrator();
            //// Has a Realation Composite        
            //DataMig.Migrate();

            //Console.ReadLine();
            /********************Has a Relations Aggreation/Union ***************************/
            //var address = new Address(325, "KH");
            //var stu = new Student("zole", 25, "Palestine", address);
            //var stu1 = new Student("tam", 25, "Palestine", address);

            //var stu2 = new Student("Abdallah", 25, "Palestine", address);

            //stu.PrintInfo();
            //Console.WriteLine("Student Count: "+ Student.count);

            /********************************/
            //var arlist1 = new ArrayList();

            //var arlist2 = new ArrayList()
            //        {
            //            1, "Bill", " ", true, 4.5, null
            //        };
            //Console.WriteLine(arlist2[3]);
            //int[] arr = { 100, 200, 300, 400 };

            //Queue myQ = new Queue();
            //myQ.Enqueue("Hello");
            //myQ.Enqueue("World!");

            //arlist1.AddRange(arlist2); //adding arraylist in arraylist 
            //arlist1.AddRange(arr); //adding array in arraylist 
            //arlist1.AddRange(myQ);//adding Queue in arraylist 

            //Console.WriteLine(arlist1[10]);

            //// Implement IList inteface so we can use the Index
            //arlist1[0] = "Steve";
            //arlist1[1] = 5;

            //// Implement ICollection Interface so we can use for foreach Count
            //foreach (var item in arlist1)
            //    Console.Write(item + ", ");

            //Console.WriteLine("\n *********************");
            //arlist1.Insert(12, false);

            //for (int i = 0; i < arlist1.Count; i++)
            //    Console.Write(arlist1[i] + ", ");


            //ArrayList arlist3 = new ArrayList()
            //    {
            //        15, 25, 35
            //    };

            //arlist1.InsertRange(2, arlist3);

            //Console.WriteLine("\n *********************");
            //for (int i = 0; i < arlist1.Count; i++)
            //    Console.Write(arlist1[i] + ", ");
            /***********************************/
            //Printer printer = new Printer();
            //printer.Print<int>(100);
            //printer.Print(200); 
            //printer.Print<string>("Hello");
            //printer.Print("World!");




            //KeyValuePair<string, int> kv = new KeyValuePair<string, int>();
            //kv.Key = "a";
            //kv.Value = 5;


            //Console.WriteLine(kv.Key);

            //var ds = new DataStore<int>();
            //ds.Data = 5;
            //ds.AddOrUpdate(0,5);
            //ds.AddOrUpdate(1, 2);
            //ds.AddOrUpdate(2, 25);
            //var cities = new DataStore<string>();
            //cities.AddOrUpdate(0, "Mumbai");
            //cities.AddOrUpdate(1, "Chicago");
            //cities.AddOrUpdate(2, "London");
            //var a = new A();
            //var aa = new A("Kh");
            //Console.WriteLine(a.name);
            //Console.WriteLine(aa.name);


            //int[] evenNums;  // integer array

            //string[] cities; // string array

            //int[] evenNums =  { 2, 4, 6, 8, 10 };

            //string[] cities = { "Mumbai", "London", "New York" };

            //var num = new int[5];

            //Console.WriteLine(num[2]);

            //            int[] evenNums = { 2, 4, 6, 8, 10 };

            //            for (int i = 0; i < evenNums.Length; i++)
            //                Console.WriteLine(evenNums[i]);


            //            Console.WriteLine("*******************");
            //            for (int j = 0; j < evenNums.Length; j++)
            //            {
            //evenNums[j] = evenNums[j] + 10;
            //            Console.WriteLine(evenNums[j]);
            //            }




            //int[] evenNums = { 2, 4, 6, 8, 10 };
            //string[] cities = { "Mumbai", "London", "New York" };

            //foreach (var item in evenNums)
            //    Console.WriteLine(item);

            //foreach (var city in cities)
            //    Console.WriteLine(city);

            //int[] nums = new int[5] { 10, 15, 16, 8, 6 };
            //Console.WriteLine(nums.Max());
            //Console.WriteLine(nums.Min());
            //Console.WriteLine(nums.Sum());

            //Console.WriteLine(nums.Average());

            //Console.WriteLine(Array.Sort( nums));


            //int[,] arr1d = new int[3, 2]{
            //                    {1, 2},
            //                    {3, 4},
            //                    {5, 6}
            //                };

            //// or 
            //int[,] arr2d = {
            //        {1, 2},
            //        {3, 4},
            //        {5, 6}
            //    };


            //Console.WriteLine(arr1d[2, 1]);
            #endregion

        }
       
    }
}
