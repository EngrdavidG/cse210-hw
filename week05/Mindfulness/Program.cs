using System;

class Program
{
    /*
     * Enhancements Beyond Core Requirements:
     * --------------------------------------
     * 1. Reflection Activity prevents repetition of prompts and questions
     *    until all have been used, ensuring a richer and less repetitive experience.
     * 2. Expanded lists of prompts and questions to deepen user engagement.
     * 3. Console.Clear() is used to provide a cleaner and more focused user interface.
     * 4. Improved spinner and countdown animations for better user experience.
     * 5. Listing Activity counts and displays the number of items entered by the user.
     *
     * These enhancements demonstrate creativity and extend the functionality
     * beyond the core assignment requirements.
     */

    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select an option: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (choice == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
        }

        Console.WriteLine("\nThank you for using the Mindfulness Program. Stay mindful!");
    }
}