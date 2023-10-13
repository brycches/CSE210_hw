using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6,7);
        Console.WriteLine($"fraction 1 {fraction1.GetFractionString()} fraction 2 {fraction2.GetFractionString()} fraction 3 {fraction3.GetFractionString()}");
        Console.WriteLine(fraction1.GetDecimalValue());
        Console.WriteLine(fraction2.GetDecimalValue());
        Console.WriteLine(fraction3.GetDecimalValue());
        
    }
}