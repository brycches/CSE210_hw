using System;

class Program
{
    static void Main()
    {
        string scriptureText = "John 3:16";

        var scripture = new Scripture(scriptureText);
        var random = new Random();
        int counter = 0;
        while (!scripture.AllWordsHidden)
        {
            Console.Clear();
            if (counter > 0)
                scripture.HideRandomWord(random);
            Console.WriteLine(scripture.GetHiddenText());
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.Equals("quit", StringComparison.OrdinalIgnoreCase))
                break;
            counter += 1;
        }

        Console.WriteLine("All words in the scripture are hidden. Press Enter to exit.");
        Console.ReadLine();
    }
}

