// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



//Default Paramater
void greet(string theStr, string prefix = ">>>")
{
    System.Console.WriteLine($"{prefix} {theStr}");
};

greet("Gloria");
greet("Nihil", "***->>");


//Named Parameters
greet(prefix: "99999000>>>>", theStr: "NAAAAAAAMEEEE");