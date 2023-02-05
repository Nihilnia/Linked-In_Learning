// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//return type
double doIt(double a, double b)
{
    return a + b;
};

System.Console.WriteLine(doIt(12.4, 12.5));

//void type with def arg
void sayHello(string name = "Gloria")
{
    System.Console.WriteLine($"Hello {name}");
};

sayHello();