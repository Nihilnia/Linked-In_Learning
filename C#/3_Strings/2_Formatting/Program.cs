// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string Gloria = "Gloria";
int aNumb = 234235235;


//Basic formatting
System.Console.WriteLine("{0}", Gloria);

//Common types
/*
Number (N)
General (G)
Fixed-point (F)
Exponential (E)
Decimal (D)
Percent (P)
Hexadecimal (X)
Currency (C)
*/

System.Console.WriteLine("{0:D}, {0:N}, {0:F}, {0:G}", aNumb);
System.Console.WriteLine("{0:E}, {0:N}, {0:F}, {0:G}", aNumb);

//- Add a number after the format to specify precision
System.Console.WriteLine("{0:E3}, {0:N2}, {0:F}, {0:G}", aNumb);



//Numeral formatting


//General formattin
