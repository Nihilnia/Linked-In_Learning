// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("Give a number: ");
try
{

    int givenNumber = Convert.ToInt32(Console.ReadLine());
    if (givenNumber > 1000)
    {
        throw new ArgumentOutOfRangeException("x", "x is the limit");
    }

    System.Console.WriteLine("Given number is: " + givenNumber);
}
catch (ArgumentOutOfRangeException Err)
{
    Console.WriteLine("1000 is the limit.");
    System.Console.WriteLine(Err.Message);
}
finally
{
    System.Console.WriteLine("This block always works, whatever it happens");
}