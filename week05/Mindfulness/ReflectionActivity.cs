using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private List<string> _usedPrompts = new List<string>();
    private List<string> _usedQuestions = new List<string>();
    private Random _random = new Random();

    public ReflectionActivity()
        : base(
            "Reflection",
            "This activity will help you reflect on times in your life when you have shown strength and resilience."
        )
    {
    }

    private string GetRandomItem(List<string> items, List<string> usedItems)
    {
        if (usedItems.Count == items.Count)
        {
            usedItems.Clear(); // Reset once all have been used
        }

        string item;
        do
        {
            item = items[_random.Next(items.Count)];
        } while (usedItems.Contains(item));

        usedItems.Add(item);
        return item;
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetRandomItem(_prompts, _usedPrompts);
        Console.WriteLine($"\n{prompt}");
        Console.WriteLine("\nTake a moment to reflect...");
        ShowSpinner(5);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string question = GetRandomItem(_questions, _usedQuestions);
            Console.WriteLine($"\n{question}");
            ShowSpinner(4);
        }

        DisplayEndingMessage();
    }
}