using System;

class Program
{
    static void Main(string[] args)
    {
        string playAgain = "yes";

        while (playAgain == "yes")
        {
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            int guess = 0;
            int guessCount = 0;

            Console.WriteLine("Guess My Number Game!");

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());

                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            Console.WriteLine("You guessed the number in " + guessCount + " guesses.");

            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();

            Console.WriteLine();
        }

        Console.WriteLine("Thank you for playing!");
    }
}

