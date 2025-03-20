using System;

class Program
{
    static void Main(string[] args)
    {
        // Example scripture
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding.");

        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine(scripture.GetDisplayText());

        // Example interaction loop
        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(2);
            Console.WriteLine(scripture.GetDisplayText());
        }

        Console.WriteLine("\nProgram finished.");
    }
}
