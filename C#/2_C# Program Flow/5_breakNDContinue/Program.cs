// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



int[] exArray = new int[] { 1, 2, 3, 4, 5, 6 };

foreach (int f in exArray)
{
    if (f == 4)
    {
        System.Console.WriteLine("GTFO");
        break;
    }

    if (f % 2 == 0)
    {
        System.Console.WriteLine("Yeah it' s an even number.");
        continue;
    }
    System.Console.WriteLine("Current: " + f);
}