// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


int numb_01 = 10;
int numb_02 = 20;

//Normally
int doIt(int arg_01)
{
    arg_01 += 10;
    return arg_01;
};

System.Console.WriteLine(doIt(numb_01));
System.Console.WriteLine("Without ref:" + numb_01);

//With Ref
int doIt2(ref int arg_01)
{
    arg_01 += 10;
    return arg_01;
};

System.Console.WriteLine(doIt2(ref numb_01));
System.Console.WriteLine("With ref:" + numb_01);



//With a string value, ex
string userName = "Gloria";

string changeTheUserName(ref string theUserName)
{
    theUserName += "_User";
    return theUserName;
};

System.Console.WriteLine("Username without ref:" + userName);
System.Console.WriteLine(changeTheUserName(ref userName));
System.Console.WriteLine("Username with ref:" + userName);


//What if ref has no value
int a = 10;

int asd(ref int theValue)
{
    theValue += 12;
    return theValue;
};

System.Console.WriteLine(asd(ref a));
//Not workin'



//Out- parameter/ s
void outEm(int x, int y, out int c, out int d)
{
    c = x + 10;
    d = y + 10;
};

int t, z;
outEm(12, 22, out t, out z);
System.Console.WriteLine(t);
System.Console.WriteLine(z);