using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Defining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hell.");

            var theUser = new User("Nihil", "123", true, "Somethings");

            theUser.Name = "Gloria";
            theUser.Password = "123321";
            theUser.Activity = false;
            theUser.Bio = "eHHH.";

            theUser.LoneDigger = 111;

            System.Console.WriteLine(theUser.Introduce);
            System.Console.WriteLine(theUser.LoneDigger);

            System.Console.WriteLine("---------");

            var theBM = new BioMachine(0, "Experiment_01", "333", false, "unknown");

            theBM.LoneDigger = 222;
            System.Console.WriteLine(theBM.Introduce);
            System.Console.WriteLine(theBM.LoneDigger);
            System.Console.WriteLine(theBM.ToString());

            System.Console.WriteLine("333333333333333333333333333");

            System.Console.WriteLine("Overrided: " + theBM.ToString());
            System.Console.WriteLine("Overloaded, L: " + theBM.ToString('L'));
            System.Console.WriteLine("Overloaded, S: " + theBM.ToString('S'));
            System.Console.WriteLine("Overloaded, ELSE: " + theBM.ToString('A'));


        }
    }
}
