public class Common
{
    public void Timer(int seconds)
    {
        DateTime startTime = DateTime.Now;
        // Console.WriteLine(startTime);
        DateTime futureTime = startTime.AddSeconds(seconds);
        // Console.WriteLine(futureTime);

        int counter = 0;
        while (startTime < futureTime)
        {
            Console.Write($"\b{counter}");
            Thread.Sleep(500);
            // Console.Write("\b \b");
            string backSpace = "\b";
            for (int i = 0; i < counter; i++)
            {
                backSpace += '\b';

            }

            Console.Write($"{backSpace} ");
            startTime = DateTime.Now;
            counter += 1;
            Thread.Sleep(500);

        }
    }
    public bool Description(string activity)
    {
        if (activity == "reflection")
        {
            Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        }
        else if (activity == "breath")
        {
            Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        }
        else
        {
            Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        }

        Console.WriteLine("would you like to continue with this activity? [y/n] ");
        string description = Console.ReadLine();
        if (description.ToLower().Contains("y"))
        {
            return true;
        }
        else
            return false;
    }
}