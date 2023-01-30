// // See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// int myVal = 15;
// int[] nums = new int[] { 3, 14, 15, 92, 6, 45, 4534, 1313 };
// string str = "The quick brown fox jumps over the lazy dog";

// Console.WriteLine("The basic for loop:");
// for (int f = 0; f < nums.Length; f++)
// {
//     Console.WriteLine("f is currently {0} and the array' s number is: {1}", f, nums[f]);
// }

// System.Console.WriteLine("#");

// foreach (int f in nums)
// {
//     System.Console.WriteLine("f is currently: " + f);
// }

// int o = 0;
// foreach (char f in str)
// {
//     if (f == 'e')
//     {
//         o++;
//     }
// }

// System.Console.WriteLine("Result is: " + o);



//Basic letter/ char search program
Console.WriteLine("Give me a paragraph or anything: ");
string givenText = Console.ReadLine();


Console.WriteLine("What do you wanna search?: ");
string wannaSearch = Console.ReadLine();

int result = 0;
foreach (char f in givenText)
{
    if (Char.ToUpper(f) == Convert.ToChar(wannaSearch) || f == Convert.ToChar(wannaSearch))
    {
        result += 1;
    }
}

System.Console.WriteLine("Searched for {0} and found as much: {1}", wannaSearch, result);