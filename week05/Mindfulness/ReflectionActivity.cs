using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time you helped someone.",
        "Think of a time you did something hard.",
        "Think of a time you showed strength."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn?"
    };

    private Random _random = new Random();

    public ReflectionActivity()
        : base("Reflection",
        "This helps you reflect on meaningful experiences.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = _prompts[_random.Next(_prompts.Count)];
        Console.WriteLine($"\n{prompt}");

        Console.WriteLine("\nThink deeply...");
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = _questions[_random.Next(_questions.Count)];
            Console.WriteLine($"\n{question}");
            ShowSpinner(4);
        }

        DisplayEndingMessage();
    }
}