using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace try_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int jumpCount = 10;
            string[] animalz = { "goats", "cats", "pigs" };


            //Creatin' the string builder
            StringBuilder sb = new StringBuilder("Initial string.", 200);


            //Printin' the some basic stats of it
            System.Console.WriteLine($"Capacity: {sb.Capacity}, Length: {sb.Length}");


            //Adding some strings to the builder using Append
            sb.Append("Nihil");
            sb.Append("Gloria");
            System.Console.WriteLine(sb);

            //Append a line
            sb.AppendLine();

            //Append format (can be used to appends formatted strings)
            sb.AppendFormat($"Somethings happened {jumpCount} times.");
            sb.AppendLine();

            //AppendJoin
            sb.Append("Aj");
            sb.AppendJoin(",", animalz);

            //Modift the content using replace
            sb.Replace("Nihil", "the Evil God");

            //Insert for insterting any content with any index
            sb.Insert(sb.Length - 1, "Nihil is here again");

            //Convert to a single string
            System.Console.WriteLine($"Capacity: {sb.Capacity}, Length: {sb.Length}");
            System.Console.WriteLine(sb.ToString());


            Console.ReadKey();


        }
    }
}
