// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string userIput = "Q";



while (userIput != "Q")
{
    userIput = Console.ReadLine();
    System.Console.WriteLine("You entered: " + userIput);
}


string userIput2 = "Q"; //doesnt matter its gonna work

do
{
    break;
    userIput2 = Console.ReadLine(); //and will wait for input
    System.Console.WriteLine("You entered: " + userIput2);
} while (userIput2 != "Q");