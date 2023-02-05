using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Parsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numStr_1 = "1";
            string numStr_2 = "2.00";
            string numStr_3 = "3,000";
            string numStr_4 = "4.0000.00";


            //The parse function attempts to parse a string to into a number
            //but if the string format is not 'right' to conversation then it throws an exception
            //ofc.


            //int.parse()
            //double.parse()
            //decimal.parse()
            //float.parse()
            //string.parse()

            //toString()

            int doIt = 0;
            // double doIt2 = 0;
            try
            {
                doIt = int.Parse(numStr_1); //It works.
                doIt = int.Parse(numStr_2, NumberStyles.Float); //It will work, only if the decimal value is zero.
                doIt = int.Parse(numStr_3); //It gives error.
                doIt = int.Parse(numStr_4); //It gives error.
                System.Console.WriteLine("Parsing has no error.");
            }
            catch (Exception Err)
            {
                System.Console.WriteLine(Err.Message);
                System.Console.WriteLine("Parsing has error.");
            }

            //Ps: you can parse the string value into bool, it works if the string is 'okay' to be parse
            System.Console.WriteLine(bool.Parse("False"));
            System.Console.WriteLine(bool.Parse("False").GetType());

            //TRyParse
            int theNum = 0;
            bool succeeded = Int32.TryParse(numStr_1, out theNum);
            System.Console.WriteLine(succeeded);

            Console.ReadKey();

        }
    }
}
