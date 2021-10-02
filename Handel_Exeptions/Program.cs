using System;
using System.IO;

namespace Handel_Exeptions
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"D:\DotNetConsole1\Text1.txt");
                Console.WriteLine(streamReader.ReadToEnd());
            }
            // Custom Exception Catch Handller
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //  Custom Exception Catch Handller
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);

            }
            // Base Exeption 
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

            finally
            {
                if (streamReader != null) 
                    streamReader.Close();
            }

        }
    }
}
