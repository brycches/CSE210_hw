using System;

class Program
{
    static void Main(string[] args)
    {
        bool done = false;
        Breath breath = new Breath();
        Reflection reflection = new Reflection();
        Listing listing = new Listing();
        Common common = new Common();
    
        while (done == false)
        {
            Console.WriteLine("Which activity would you like to do? [breathing, reflection, listing]");
            string activity = Console.ReadLine();
            if (activity.ToLower().Contains("breathing"))
            {
                int time = getTime(0);
                if (common.Description("breath"))
                {
                    breath.RunBreath(time);
                }
                else
                {
                    continue;
                }
                done = true;
            }
            else if (activity.ToLower().Contains("reflection"))
            {
                int time = getTime(20);
                if (common.Description("reflection") && time >= 20)
                {
                    reflection.RunReflection(time);
                }
                else if(time < 20)
                {
                    Console.WriteLine("This activity requires at least 20 seconds of your time, please try again.");
                    continue;
                }
                else
                {
                    continue;
                }
                done = true;

            }
            else if (activity.ToLower().Contains("listing"))
            {
                int time = getTime(11);
                if (common.Description("listing") && time > 11)
                
                {
                    listing.RunListing(time);
                }
                else if(time <= 10)
                {
                    Console.WriteLine("This activity requires at least 10 seconds of your time, please try again.");
                    continue;
                }
                else
                {
                    continue;
                }
                done = true;
            }
            else
            {
                Console.WriteLine("please enter one of the listed activities");
            }
        }
        Console.WriteLine("Thank you for taking some time to be mindful.");

        static int getTime(int minimum)
        {
            while(true)
            {
                Console.WriteLine("How long would you like to participate in this activity (in seconds)?");
                string timeS = Console.ReadLine();
                int time = int.Parse(timeS);
                if (time >= minimum)
                {
                    return time;
                }
                else
                {
                    Console.WriteLine($"You need at least {minimum} seconds for this activity.");
                    continue;
                };

            }
            
            

        }
    }
}