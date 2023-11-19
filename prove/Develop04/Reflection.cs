public class Reflection : Common
{
    public void RunReflection(int time)
    {
        Random random = new Random();
        Common timer = new Common();
        Console.WriteLine("Get ready for the Reflection activity");
        Console.WriteLine("");
        while (time >= 20)
        {
            List<string> prompts = new List<string> {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };
            int randomIndex = random.Next(0, prompts.Count);
            Console.WriteLine(prompts[randomIndex]);
            Console.WriteLine("");
            timer.Timer(10);
            time = time - 10;
            List<string> reflections = new List<string> {
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?",
            };
            randomIndex = random.Next(0, reflections.Count);
            Console.WriteLine(reflections[randomIndex]);
            Console.WriteLine("");
            timer.Timer(10);
            time = time - 10;

        }
    }
}