System.Console.WriteLine("Let' s play 'guess the number game.");
System.Console.WriteLine("I have a number between 0- 20");
System.Console.WriteLine("Enter your guess, or -1 to exit.");

Random rnd = new Random();
int randomNum = rnd.Next(0, 21);

int right = 3;

while (true && right != 0)
{
    System.Console.WriteLine("What' s your guess?: ");
    try
    {
        int userChoice = int.Parse(Console.ReadLine());

        if (userChoice == -1)
        {
            break;
        }
        else
        {
            if (randomNum == userChoice)
            {
                System.Console.WriteLine("Well done, number was: " + randomNum);
                break;
            }
            else
            {
                if (userChoice < randomNum)
                {
                    System.Console.WriteLine("Nope, higher than this.");
                    right--;
                    System.Console.WriteLine($"You have {right} more to guess..");
                }
                else
                {
                    System.Console.WriteLine("Nope, lower than this.");
                    right--;
                    System.Console.WriteLine($"You have {right} more to guess..");
                }

            }
        }


    }
    catch (Exception Err)
    {
        System.Console.WriteLine("It' s not a number you cunt.");
    }


}