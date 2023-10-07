using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        Random rnd = new Random();
        int num = rnd.Next(0, prompts.Count);
        Console.WriteLine($"{prompts[num]}");

        // Create a new Entry
        Entry entry = new Entry
        {
            EntryDate = DateTime.Now.ToShortDateString(),
            Prompt = prompts[num],
            Response = Console.ReadLine()
        };

        // Create a new journal
        Journal journal = new Journal();
        Console.WriteLine("what is the name of your journal? ");
        journal.Name = Console.ReadLine();

        // Add the entry to the journal
        journal.Entries.Add(entry);

        Console.WriteLine("What is the name of your journal file? ");
        string fileName = Console.ReadLine();

        // Save journal entries to a file in JSON format
        SaveJournalToJsonFile(journal, fileName);

        Console.WriteLine("Do you want to load a journal from a file? y/n ");
        string load = Console.ReadLine();
        if (load.ToLower() == "y")
        {
            // Load journal from JSON file using the same fileName
            journal = LoadJournalFromJsonFile(fileName);
        }

        Console.WriteLine("Would you like to print your journal? y/n ");
        string printJournal = Console.ReadLine();
        if (printJournal.ToLower() == "y")
        {
            foreach (Entry journalEntry in journal.Entries)
            {
                // Display each entry
                Console.WriteLine($"Date: {journalEntry.EntryDate}");
                Console.WriteLine($"Prompt: {journalEntry.Prompt}");
                Console.WriteLine($"Response: {journalEntry.Response}");
                Console.WriteLine();
            }
        }
    }

    static void SaveJournalToJsonFile(Journal journal, string fileName)
    {
        string json = JsonSerializer.Serialize(journal);

        // Save the JSON string to the file
        File.AppendAllText(fileName, json);
    }

    static Journal LoadJournalFromJsonFile(string fileName)
    {
        try
        {
            string json = File.ReadAllText(fileName);

            // Deserialize the JSON string back to a Journal object
            Journal journal = JsonSerializer.Deserialize<Journal>(json);

            return journal;
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("The specified file was not found.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred: {e.Message}");
        }

        return new Journal(); // Return an empty journal if loading fails
    }
}