//See https:aka.ms / new- console - template for more information
Console.WriteLine("Hello, World!");



var Glr = 1130;

if (Glr == 10)
{
    Console.WriteLine("ah, 10");
}
else if (Glr == 110)
{
    Console.WriteLine("Maybeee 110?");
}
else
{
    Console.WriteLine("Above mfs. not worked so.");
}




while (true)
{
    Console.WriteLine("Give me the number between 1- 100 (For quit 'Q')");
    string userInput = Console.ReadLine();

    if (userInput != "Q")
    {
        int result = Convert.ToInt32(userInput);
        if (result < 50)
        {
            Console.WriteLine("The number that you given is smaller than 50.");
        }
        else if (result == 50)
        {
            Console.WriteLine("The number that you given is equal 50.");
        }
        else if (result >= 50 && result < 100)
        {
            Console.WriteLine("The number that you given is greater than 50.");
        }
        else
        {
            Console.WriteLine("I said 1- 100 you mf.");
        }
    }
    else
    {
        Console.WriteLine("See ya!");
        break;
    }

}


Console.WriteLine("Give me the number between 1- 100");
Console.WriteLine(Convert.ToInt32(Console.ReadLine()) < 50 ? "Smallar than 50" : "Greater than 50");