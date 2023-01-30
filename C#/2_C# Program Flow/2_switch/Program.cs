// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var GLR = 5;

switch (GLR)
{
    case 5:
    case 10:
    case 15:
        Console.WriteLine("GLR is 5 or 10 or 15 lmao");
        break;

    case 20:
        Console.WriteLine("GLR is 10");
        break;

    case 30:
        Console.WriteLine("GLR is 15");
        break;

    case 40:
        Console.WriteLine("GLR is 12");
        break;

    default:
        Console.WriteLine("Else");
        break;
}


Console.WriteLine("Give me a char: ");
char userInput = Convert.ToChar(Console.ReadLine());


switch (userInput)
{
    case 'G':
        Console.WriteLine("Given: G");
        break;


    case 'L':
        Console.WriteLine("Given: L");
        break;

    case 'R':
        Console.WriteLine("Given: R");
        break;

    default:
        Console.WriteLine("Given char is not G- L- R");
        break;

}


Console.WriteLine("Better option for this case:");
Console.WriteLine(userInput == 'G' || userInput == 'L' || userInput == 'R' ? "Given char is in G- L- R" : "Given char is not G- L- R");