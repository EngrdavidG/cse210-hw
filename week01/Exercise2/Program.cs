using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradepercentage = Console.ReadLine();

        // Convert the user's input into a number
        int grade = int.Parse(gradepercentage);

        string letter = "";

        // Determine the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        // Stretch Challenge: Determine + or -
        string sign = "";

        int lastDigit = grade % 10;

        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        // Handle special cases
        if (letter == "A" && sign == "+")
        {
            sign = "";   // No A+
        }

        if (letter == "F")
        {
            sign = "";   // No F+ or F-
        }

        // Print the final grade
        Console.WriteLine("Your letter grade is: " + letter + sign);

        // Check if the student passed
        int passmark = 70;

        if (grade >= passmark)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Unfortunately, you did not pass the course. Better luck next time!");
        }
    }
}