using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        int total = 0;
        int biggest = -999999;
        List<int> numbers = new List<int>();
        int additional = 0;
        do{
            Console.WriteLine("Please enter a number to add to the list, type 0 to quit ");
            string wanted = Console.ReadLine();
            additional = int.Parse(wanted);
            if (additional != 0)
            {
                numbers.Add(additional);
            }

        } while (additional != 0);
        foreach (int number in numbers)
            {
                total += number;
                if(number > biggest){
                    biggest = number;
                }
            }
            Console.WriteLine($"the total of your numbers is {total}");
        
        int average = total / numbers.Count();
        Console.WriteLine($"the average of your numbers is {average}");
        Console.WriteLine($"the biggest of your numbers is {biggest}");

    }
}