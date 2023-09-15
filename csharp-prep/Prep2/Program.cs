using System;

class Program
{
    static void Main(string[] args)
    {
        string sign = "";
        string pass ="";
        string letter = "";
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("What is your grade percentage? ");
        string grades = Console.ReadLine();
        int gradei = int.Parse(grades);
        if (gradei >= 90)
        {
            letter = "A";
            pass ="true";
        }
        else if (gradei >= 80)
        {
            letter = "B";
            pass ="true";
        }
        else if (gradei >= 70)
        {
            letter = "C";
            pass ="true";
        }
        else if (gradei >= 60)
        {
            letter = "D";
            pass ="true";
        }
        else if (gradei < 60)
        {
            letter = "F";
            pass ="false";
        }
        int gradeSign = gradei % 10;
        if (gradeSign >=7 && letter != "A" && letter != "F")
        {
            sign = "+";
        }
        else if (gradeSign < 3 && letter != "F")
        {
            sign = "-";
        }
        if (pass =="true")
        {

            Console.Write($"you got a {letter}{sign} you pass! ");

        }
        else
        {
            Console.Write($"you got an {letter}{sign} you fail. ");
        }

    }
}