using System;
using System.Collections.Generic;
using System.Linq;

namespace Extension_Methods
{
   
    class Program
    {
        static void Main(string[] args)
        {
            string x = "Extension Method Test";
            x.PrintStringValue();

            string y = "15";
            y.PrintStringValue();
            y.ToIntegerValue();


            //var z = new List<string>();
            //z.First
        }
    }
}
