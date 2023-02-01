// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string make = "Mitsubishi";
string model = "Lancer Evo";
int year = 1998;
float miles = 8_450.27f;
decimal price = 60_275.0m;


//General formatting
System.Console.WriteLine("This car is a {0} {1} {2}, with {3} miles and costs ${4}",
year, make, model, miles, price);

System.Console.WriteLine("#########################");

//Using String Interpolation
System.Console.WriteLine($"This car is a {year} {make} {model}, with {miles} miles and costs ${price}");



//Inline Expression- (take a look)