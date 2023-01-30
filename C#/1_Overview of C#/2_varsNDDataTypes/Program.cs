// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Some basic value type variables
int f = 10;
float a = 2.0f;
decimal d = 10.0m;
bool b = true;
char t = 't';

//String
string str = "sss";


//Implicit Variables
var x = 10;
var z = "Ayye";

//Arrays
int[] exIntArray = new int[3];
string[] exStrArray = { "asd", "asdas", "asda" };

Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}",
f, a, d, b, t, str, x, z);

//Null
object Gloria = null;
Console.WriteLine(Gloria);

//Implicit conversion between types
long aLongNumb;
aLongNumb = f;

//Explicit conversions
float asd = (float)f;
Console.WriteLine(asd);

int asdg = (int)a;
Console.WriteLine(asdg);