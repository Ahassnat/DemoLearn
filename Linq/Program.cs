using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
    }
    class Student:Person
    {
        public int Id { get; set; }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();
            students.Add(new Student { Id = 01, Name = "Abdallah", Age = 25 });
            students.Add(new Student { Id = 02, Name = "Salem", Age = 12 });
            students.Add(new Student { Id = 03, Name = "Ahmed", Age = 32 });
            students.Add(new Student { Id = 04, Name = "Kh", Age = 47 });
            students.Add(new Student { Id = 05, Name = "Samy", Age = 15 });
            students.Add(new Student { Id = 06, Name = "Suman", Age = 30 });
            students.Add(new Student { Id = 07, Name = "Gasem", Age = 51 });


            var pepoles = new List<Person>();
            pepoles.Add(new Person {  Name = "Abdallah", Age = 25,Country="Palestine" });
            pepoles.Add(new Person {  Name = "Salem", Age = 12 ,Country="Palestine"});
            pepoles.Add(new Person { Name = "Ahmed", Age = 32, Country = "Palestine" });
            pepoles.Add(new Person {  Name = "Kh", Age = 47, Country = "Gaza" });
            pepoles.Add(new Person {  Name = "Samy", Age = 15, Country = "Gaza" });
            pepoles.Add(new Student { Id = 06, Name = "Suman", Age = 30, Country = "Gaza" });

            var p = pepoles.Where(pr => pr is Student).Cast<Student>();
            var groupP = pepoles.OrderBy(x => x.Age).GroupBy(x => x.Country);

            foreach (var gr in groupP)
            {
                Console.WriteLine($"Country: {gr.Key}");
                foreach (var per in gr)
                {
                    Console.WriteLine("    Name: "+ per.Name);
                    Console.WriteLine("    Age: " + per.Age);

                }
            }
            
            //foreach (var item in p)
            //{
            //    Console.WriteLine(item.Name);
            //}

            var myStudentQuery = from stu in students
                                 where stu.Age < 40
                                 orderby stu.Age
                                 select stu.Name;
            var st = students.Where(x => x.Age < 20).Cast<Person>();
            //foreach (var item in myStudentQuery)
            //{
            //    Console.WriteLine("Student Name: "+ item);
            //    Console.WriteLine("//////////////////////////////////////////");
            //}
            //foreach (var item in st)
            //{
            //    Console.WriteLine("Student Name: " + item);
             

            //}
            /* LINQ Query/*/
            List<string> names = new List<string>() { "Ahmad", "Mohammed", "Mahmoud", "Salem" };
            IEnumerable<string> MyFirstQuery = from name in names
                               where name.StartsWith("A")
                               select name;
            var myLinqMethod = names.Where(x => x.Contains("l"));
            //foreach (var item in MyFirstQuery)
            //{
            //    Console.WriteLine(item);

            //}
            //foreach (var item in myLinqMethod)
            //{
            //    Console.WriteLine(item);

            //}

            /**/




        }
    }
}
