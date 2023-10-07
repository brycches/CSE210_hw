using System;
using System.IO;
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
        journal.Name = "";

        // Add the entry to the journal
        journal.Entries.Add(entry);

        Console.WriteLine("What is the name of your journal file? ");
        string fileName = Console.ReadLine();

        // Write journal entries to a file
        using (StreamWriter outputFile = File.AppendText(fileName))
        {
            foreach (Entry journalEntry in journal.Entries)
            {
                // Write each entry to the file
                outputFile.WriteLine($"Date: {journalEntry.EntryDate}");
                outputFile.WriteLine($"Prompt: {journalEntry.Prompt}");
                outputFile.WriteLine($"Response: {journalEntry.Response}");
                outputFile.WriteLine();
            }
        }

        Console.WriteLine("Do you want to load a journal from a file? y/n ");
        string load = Console.ReadLine();
        if (load.ToLower() == "y")
        {
            Console.WriteLine("Enter the filename to load the journal from: ");
            string loadFileName = Console.ReadLine();

            journal = new Journal();
            journal.Name = "";
            
            try
            {
                using (StreamReader inputFile = new StreamReader(loadFileName))
                {
                    string line;
                    Entry currentEntry = null;

                    while ((line = inputFile.ReadLine()) != null)
                    {
                        if (line.StartsWith("Date: "))
                        {
                            currentEntry = new Entry();
                            currentEntry.EntryDate = line.Substring("Date: ".Length);
                        }
                        else if (line.StartsWith("Prompt: "))
                        {
                            currentEntry.Prompt = line.Substring("Prompt: ".Length);
                        }
                        else if (line.StartsWith("Response: "))
                        {
                            currentEntry.Response = line.Substring("Response: ".Length);
                            journal.Entries.Add(currentEntry);
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The specified file was not found.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }

            Console.WriteLine("Journal loaded successfully.");
        }
    

        Console.WriteLine("Would you like to see all entries in your journal? y/n ");
        string print = Console.ReadLine();
        if (print.ToLower() == "y")
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
}