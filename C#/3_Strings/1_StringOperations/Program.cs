// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


string aStr;
string str1 = "AHSFkjaf askjfhaksj fasjkfasf";
string str2 = "_ string";
string str3 = "And the anotha one";
string[] strz = { "one", "two", "three", "four" };


//Length
System.Console.WriteLine("str1' s length:" + str1.Length);


//Accessing the invidual characters
System.Console.WriteLine("str1' s 14.char:" + str1[13]);

//Iteration
foreach (char f in str2)
{
    System.Console.WriteLine("Current char:" + f);
    if (f == 'n')
    {
        System.Console.WriteLine("aaaaa an 'n'");
    }
};

//Concatenation
aStr = String.Concat(strz);
System.Console.WriteLine(aStr);

//Join
aStr = String.Join(" _# # #_ ", strz);
System.Console.WriteLine(aStr);

//Comparison

string a = "b";
string b = "b";
int result = String.Compare(a, b);
switch (result)
{
    case < 0:
        System.Console.WriteLine("In order a comes before b");
        break;

    case 0:
        System.Console.WriteLine("They are equal");
        break;

    default:
        System.Console.WriteLine("In order b comes before c");
        break;

}
System.Console.WriteLine();


//Equality
bool isEqual = a.Equals(b);
System.Console.WriteLine(isEqual);


//String searching
System.Console.WriteLine(str2.IndexOf("string"));


//Replace
string newString = str2.Replace("string", "Gloria");
System.Console.WriteLine(newString);