using System;
using System.Collections.Generic;

namespace Delegates
{
    //class Employee
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public int Salary { get; set; }
    //    public int Experince { get; set; }
    //    public static void Promotion(List<Employee> employee, IsPromoted isEljable)
    //    {
    //        foreach (var empList in employee)
    //        {
    //            if (isEljable(empList)) { Console.WriteLine("Emp Name: " + empList.Name + " Promoted"); }
    //        }

    //    }
    //}
    //delegate bool IsPromoted(Employee employee);
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        var employeeList = new List<Employee>();
    //        employeeList.Add(new Employee { Id = 101, Name = "Abdallah", Salary = 5000, Experince = 8 });
    //        employeeList.Add(new Employee { Id = 102, Name = "Maher", Salary = 4000, Experince = 4 });
    //        employeeList.Add(new Employee { Id = 103, Name = "Mohammad", Salary = 3000, Experince = 6 });
    //        employeeList.Add(new Employee { Id = 104, Name = "Nasser", Salary = 2000, Experince = 2 });
    //        employeeList.Add(new Employee { Id = 105, Name = "Radosh", Salary = 1000, Experince = 9 });
    //        employeeList.Add(new Employee { Id = 106, Name = "Shaher", Salary = 1500, Experince = 1 });
    //        var ispromotedDelegate = new IsPromoted(Promoted);
    //        Employee.Promotion(employeeList, ispromotedDelegate);


    //        static bool Promoted(Employee empPromoted)
    //        {
    //            if (empPromoted.Experince >= 5) return true;
    //            else return false;
    //        }
    //    }
    //}


    /*******MultiCast Delegate ********/
    public delegate void MutiCaseDelegateForStatments();
    class Program
    {
        static void Main(string[] args)
        {
            MutiCaseDelegateForStatments del1, del2, del3, del4;
            del1 = new MutiCaseDelegateForStatments(StatmentOne);
            del2 = new MutiCaseDelegateForStatments(StatmentTwo);
            del3 = new MutiCaseDelegateForStatments(StatmentThree);
            del4 = del1 + del2 + del3;
            del4();
        }
        public static void StatmentOne()
        {
            Console.WriteLine("Statment One ");
        }
        public static void StatmentTwo()
        {
            Console.WriteLine("Statment 2 ");
        }
        public static void StatmentThree()
        {
            Console.WriteLine("Statment 3 ");
        }

    }

}
