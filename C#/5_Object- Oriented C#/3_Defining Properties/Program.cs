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


        }
    }
}
