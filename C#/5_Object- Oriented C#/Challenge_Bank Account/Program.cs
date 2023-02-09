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
            // var bankAcc_01 = new BankAccount("Bank Acc 01", true, 2222);
            // System.Console.WriteLine(bankAcc_01.ToString());


            // System.Console.WriteLine("Deposit processing..");
            // //Deposit
            // System.Console.WriteLine(bankAcc_01.Deposit(23423));
            // System.Console.WriteLine(bankAcc_01.ToString());

            // System.Console.WriteLine("Withdrawal processing..");
            // //Withdrawal
            // System.Console.WriteLine(bankAcc_01.Withdrawal(44));
            // System.Console.WriteLine(bankAcc_01.ToString());


            int key = -1;
            BankAccount newAcc = new BankAccount();

            do
            {
                System.Console.WriteLine("""
                What do you want?
                1- Create Acc
                2- Account info
                3- Deposit
                4- Withdraw



                0- Exit

                
                """);

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        System.Console.WriteLine("Acc name: ");
                        string accName = System.Console.ReadLine();
                        System.Console.WriteLine("Total amount: ");
                        string accTotal = System.Console.ReadLine();

                        newAcc._Name = accName;
                        newAcc._isActive = true;
                        newAcc._Total = Convert.ToDouble(accTotal);

                        System.Console.WriteLine("Account created.. you can check the info' s about your acc.");

                        break;

                    case "2":
                        System.Console.WriteLine("Checking the informations of the acc..");
                        System.Console.WriteLine(newAcc.ToString());

                        break;
                }


            } while (key == -1);

        }
    }
}
