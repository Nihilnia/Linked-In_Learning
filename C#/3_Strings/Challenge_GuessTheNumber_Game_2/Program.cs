Random rnd = new Random();
int randomNumb = rnd.Next(0, 21);
int count = 3;
System.Console.WriteLine("Welcome to the Guess the number, for exit -1");
do
{
    System.Console.WriteLine("Guess the number: ");

    try
    {
        int userGuess = int.Parse(Console.ReadLine());
        if (userGuess != -1)
        {
            if (userGuess != randomNumb)
            {
                System.Console.WriteLine("Wrong guessin..  Number I have is {0} than your guess'", userGuess < randomNumb ? "Greater" : "Smaller");
                count--;
                System.Console.WriteLine("Remaining guess: " + count);

                if (count == 0)
                {
                    System.Console.WriteLine("Number I have was: " + randomNumb);
                    break;
                }
                continue;
            }

            System.Console.WriteLine("You guessed right.");

        }
        else
        {
            break;
        }
    }
    catch (Exception Err)
    {
        System.Console.WriteLine("You must give a number.");
    }
} while (count != 0);