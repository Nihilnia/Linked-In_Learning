using System.Text;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Let' s begin!");



void Palindrome(string theText)
{
    // string newText = theText.Reverse();
    StringBuilder sb = new StringBuilder();

    foreach (char f in theText)
    {
        sb.Insert(0, f.ToString());
    }

    StringBuilder _sb = new StringBuilder();
    _sb = sb;
    _sb.Replace(" ", "");
    _sb.Replace(".", "");
    _sb.Replace(",", "");
    _sb.Replace("!", "");
    _sb.Replace("'", "");

    System.Console.WriteLine("The text: " + _sb);
    System.Console.WriteLine(sb);
    System.Console.WriteLine("New text: " + sb);
    System.Console.WriteLine("It is {0}, length: {1}", sb.Equals(theText) ? "Palindrome" : "Not Palindrome", sb.Length);
};


do
{
    string givenText = Console.ReadLine();
    Palindrome(givenText);
} while (true);
