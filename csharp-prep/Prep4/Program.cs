using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        int additional = ""
        do{
            Console.WriteLine("Please enter a number to add to the list, type 0 to quit ");
            additional = Console.ReadLine();
            if (additional != 0)
            {
                numbers.append(additional);
            }

        } while (additional != 0);
        foreach (int number in numbers)
            {
                int total += number;
            }
            Console.WriteLine($"your numbers are {numbers} and thier total is {total}")
        words.Add("phone");
        words.Add("keyboard");
        words.Add("mouse");
    }
}