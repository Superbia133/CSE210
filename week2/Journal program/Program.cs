using System;
using JournalApp;

class Program
{
    static void Main()
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine() ?? "";

                    string date = DateTime.Now.ToShortDateString();
                    journal.AddEntry(new Entry(date, prompt, response));
                    Console.WriteLine("Entry added successfully.");
                    break;

                case "2":
                    journal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter file name to save (default: journal.txt): ");
                    string saveFile = Console.ReadLine() ?? "journal.txt";
                    journal.SaveToFile(saveFile);
                    break;

                case "4":
                    Console.Write("Enter file name to load (default: journal.txt): ");
                    string loadFile = Console.ReadLine() ?? "journal.txt";
                    journal.LoadFromFile(loadFile);
                    break;

                case "5":
                    Console.WriteLine("Exiting... Goodbye!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }
    }
}
