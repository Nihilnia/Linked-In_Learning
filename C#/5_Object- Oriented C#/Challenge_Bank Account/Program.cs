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
            var bankAcc_01 = new BankAccount("Bank Acc 01", true, 2222);
            System.Console.WriteLine(bankAcc_01.ToString());


            System.Console.WriteLine("Deposit processing..");
            //Deposit
            System.Console.WriteLine(bankAcc_01.Deposit(23423));
            System.Console.WriteLine(bankAcc_01.ToString());

            System.Console.WriteLine("Withdrawal processing..");
            //Withdrawal
            System.Console.WriteLine(bankAcc_01.Withdrawal(44));
            System.Console.WriteLine(bankAcc_01.ToString());

        }
    }
}
