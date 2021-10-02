using System;

namespace Extension_Methods
{
    public static class PrintString
    {
        public static void PrintStringValue(this string str)
        {
            System.Console.WriteLine(str);
        }
        public static int ToIntegerValue(this string str)
        {
            try
            {
                return Convert.ToInt32(str);
                
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
