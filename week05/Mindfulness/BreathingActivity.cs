using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing",
            "This activity will help you relax by guiding you through slow and steady breathing. Clear your mind and focus on your breath."
        )
    {
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in... ");
            ShowCountDown(4);

            Console.Write("\nBreathe out... ");
            ShowCountDown(4);
        }

        DisplayEndingMessage();
    }
}