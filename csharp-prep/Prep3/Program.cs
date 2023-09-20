using System;

class Program
{
    static void Main(string[] args)
    {
        int gNumber = 0;
        Random randomGenerator = new Random();
        int mNumber = randomGenerator.Next(1, 101);
        do {
            Console.Write("guess a number between 1 and 100. ");
            string guessed = Console.ReadLine();
            gNumber = int.Parse(guessed);

            if (gNumber > mNumber )
            {
                Console.WriteLine("your guess is too high. ");
            } else if (gNumber < mNumber)
            {
                Console.WriteLine("your guess is too low ");
            } else
            {
                Console.WriteLine("you guessed correctly! ");
                Console.WriteLine($"It took you {guesses} guesses")
            }
            int guesses += 1;
        
            } while (gNumber != mNumber);
            
        
        
            
        



    }
}