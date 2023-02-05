// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");



//Tuples (added at c# 7)
(int x, int y, string a) tuple01 = (1, 2, "Gloria");

System.Console.WriteLine($"{tuple01.x}, {tuple01.a}, {tuple01.y}");

var tuple02 = ("Nihil", 13);
System.Console.WriteLine($"{tuple02.Item1}, {tuple02.Item2}");


//Function can work with tuples
(int, int) exFunc(int a, int b)
{
    return (a + b, b * a);
};

System.Console.WriteLine(exFunc(2, 3));

(int, int) daResult = exFunc(4, 6);
System.Console.WriteLine($"Item1: {daResult.Item1}, Item2: {daResult.Item2}");
