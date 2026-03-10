using System;

class Program
{
    static void Main(string[] args)
    {
        //Type Your First Name and Press Enter
Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();

//Type Your Last Name and Press Enter
        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();
//Print the user details
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");

    }
}