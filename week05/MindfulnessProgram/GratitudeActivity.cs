using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    public GratitudeActivity() : base(
        "Gratitude Journaling",
        "This activity will help you cultivate gratitude by journaling things you’re grateful for today.")
    {
    }

    public override void Run()
    {
        Start();
        Console.WriteLine("\nList things you're grateful for today:");
        ShowCountdown(3);

        List<string> journalEntries = new();
        DateTime end = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string? input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input))
            {
                journalEntries.Add(input);
            }
        }

        Console.WriteLine($"\nYou recorded {journalEntries.Count} gratitude entries today!");
        End();
    }
}
