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
            System.Console.WriteLine("asdasd");
            var theUser = new User("Nihil", "321", false);

            theUser.Introduce();
            System.Console.WriteLine("########");
            theUser.changePassword("321");
            theUser.Introduce();
            System.Console.WriteLine("########");
            theUser.changeUserName("Gloria");
            theUser.Introduce();


        }
    }
}
