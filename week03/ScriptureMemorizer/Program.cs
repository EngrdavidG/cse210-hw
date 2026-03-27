using System;

// Creativity:
// I added support for randomly hiding only visible words,
// and structured the program into separate classes (Scripture, Word, Reference)
// to demonstrate encapsulation and improve maintainability.
class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);

        Scripture scripture = new Scripture(reference,
            "Trust in the Lord with all your heart and lean not on your own understanding");

        string userInput = "";

        while (userInput != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit:");
            userInput = Console.ReadLine();

            if (userInput != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nProgram ended.");
    }
}