using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the welcome function
        DisplayWelcome();

        // Ask for the user's name
        string userName = PromptUserName();

        // Ask for the user's favorite number
        int userNumber = PromptUserNumber();

        // Square the number
        int squaredNumber = SquareNumber(userNumber);

        // Display the final result
        DisplayResult(userName, squaredNumber);
    }

    // Function to display welcome message
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Function to ask for the user's name
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // Function to ask for the user's favorite number
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // Function to square the number
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    // Function to display the result
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine(name + ", the square of your number is " + square);
    }
}