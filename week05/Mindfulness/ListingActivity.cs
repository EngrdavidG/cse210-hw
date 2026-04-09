using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "Who are some of your personal heroes?"
    };

    private Random _random = new Random();

    public ListingActivity()
        : base(
            "Listing",
            "This activity will help you reflect on the good things in your life by listing as many items as you can."
        )
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"\n{prompt}");

        Console.WriteLine("\nYou may begin in:");
        ShowCountDown(5);

        int count = 0;
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        Console.WriteLine("\nStart listing items:");

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items. Great job!");
        DisplayEndingMessage();
    }
}