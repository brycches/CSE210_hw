public class Listing : Common
{
    public void RunListing(int time)
    {
        Random random = new Random();
        Common timer = new Common();
        Console.WriteLine("Get ready for the Reflection activity");
        Console.WriteLine("");
        List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        int randomIndex = random.Next(0, prompts.Count);
        Console.WriteLine(prompts[randomIndex]);
        Console.WriteLine("");
        timer.Timer(10);
        time = time - 10;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);
        Console.WriteLine("You may now begin entering answers to the above prompt");
        List<string> answers = new List<string> { };
        while (DateTime.Now < futureTime)
        {
            string userInput = Console.ReadLine();
            answers.Add(userInput);
        }
        Console.WriteLine($"You entered {answers.Count} answers. They were: {string.Join(", ", answers)}.");
        Console.WriteLine("Would you like to save your answers and prompts to a .txt file? (y/n)");
        string saveResponse = Console.ReadLine();

        if (saveResponse.ToLower() == "y")
        {
            Console.WriteLine("Please enter a filename for the .txt file:");
            string fileName = Console.ReadLine();

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(fileName + ".txt"))
            {
                file.WriteLine($"Prompt: {prompts[randomIndex]}");

                file.WriteLine("Answers:");
                foreach (var answer in answers)
                {
                    file.WriteLine(answer);
                }

                Console.WriteLine("Data saved to " + fileName + ".txt");
            }
        }
    }

}