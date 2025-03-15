using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    class Journal
    {
        private List<Entry> _entries = new List<Entry>();

        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }

        public void DisplayAll()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("No journal entries found.");
                return;
            }

            Console.WriteLine("\nYour Journal Entries:");
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }

        public void SaveToFile(string? file)
        {
            if (string.IsNullOrWhiteSpace(file))
            {
                Console.WriteLine("Invalid file name.");
                return;
            }

            try
            {
                using (StreamWriter outputFile = new StreamWriter(file))
                {
                    foreach (Entry entry in _entries)
                    {
                        outputFile.WriteLine($"{entry.Date}|{entry.PromptText}|{entry.EntryText}");
                    }
                }
                Console.WriteLine($"Journal saved successfully to {file}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving file: {ex.Message}");
            }
        }

        public void LoadFromFile(string? file)
        {
            if (string.IsNullOrWhiteSpace(file))
            {
                Console.WriteLine("Invalid file name.");
                return;
            }

            if (!File.Exists(file))
            {
                Console.WriteLine("File not found.");
                return;
            }

            try
            {
                _entries.Clear();
                string[] lines = File.ReadAllLines(file);
                foreach (string line in lines)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        _entries.Add(new Entry(parts[0], parts[1], parts[2]));
                    }
                }
                Console.WriteLine($"Journal loaded successfully from {file}.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading file: {ex.Message}");
            }
        }
    }
}
