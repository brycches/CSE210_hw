public class Breath
{

    public bool BreathDescription()
    {
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine("would you like to continue with this activity? [y/n] ");
        string description = Console.ReadLine();
        if (description.ToLower().Contains("y")){
            return true;
        }
        else
            return false;
    }
    public void RunBreath(int time)
    {
        Console.WriteLine("Get ready for the breathing activity");
        Console.WriteLine("");
        while (time >= 10)
        {
            Common timer = new Common();
            
            
            
            Console.Write("breath in");
            Console.WriteLine("");
            timer.Timer(5);
            time = time - 5;
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            Console.Write("breath out");
            Console.WriteLine("");
            timer.Timer(5);
            time = time - 5;
            Console.WriteLine("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");


        }
    }
}