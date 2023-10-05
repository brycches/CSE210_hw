using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> prompts = new List<string>();

        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");

        Console.WriteLine("Hello Develop02 World!");


        // create a new Entry
        Entry entry = new Entry();

        entry.EntryDate = DateTime.Now.ToShortDateString();
        entry.Prompt = "";
        entry.Response = "";

        // create a new journal
        Journal journal = new Journal();
        journal.Name = "";
        journal.Entries.Add(entry);

        //TODO: save to file

        //TODO: read from file
        









    }
}