using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StringBuilder sb = new StringBuilder("Initial string.", 200);

            System.Console.WriteLine($"Capacity: {sb.Capacity}, Length: {sb.Length}");

            Console.ReadKey();

        }
    }
}
