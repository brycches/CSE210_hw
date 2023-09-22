using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        };
        static string PromptUserName()
        {
            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();
            return name;

        }
        static int PromptUserNumber()
        {
            Console.WriteLine("What is your favorite number? ");
            string integer = Console.ReadLine();
            int number = int.Parse(integer);
            return number;
        }
        static int SquareNumber(int input)
        {
            int square = input * input;
            return square;
        }
        static void DisplayResult()
        {
            int square = SquareNumber(PromptUserNumber());
            string name = PromptUserName();
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
        static void Main()
        {
            DisplayWelcome();
            DisplayResult();
        }
        Main();
    }
}