using System.Text;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Let' s begin!");



void Palindrome(string theText)
{
    theText = theText.Replace(" ", "");
    theText = theText.Replace(".", "");
    theText = theText.Replace(",", "");
    theText = theText.Replace("!", "");
    theText = theText.Replace("'", "");

    // string newText = theText.Reverse();
    StringBuilder sb = new StringBuilder();

    foreach (char f in theText)
    {
        sb.Insert(0, f.ToString());
    }

    System.Console.WriteLine("Given text: " + theText);
    System.Console.WriteLine("Reverse text: " + sb);
    System.Console.WriteLine("It is {0}, length: {1}", sb.Equals(theText) ? "Palindrome" : "Not Palindrome", sb.Length);
};


do
{
    string givenText = Console.ReadLine();
    Palindrome(givenText);
} while (true);
