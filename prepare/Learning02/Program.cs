using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job { Company = "Company A", JobTitle = "Title A", StartYear = 2010, EndYear = 2015 };


        Job job2 = new Job { Company = "Company B", JobTitle = "Title B", StartYear = 2011, EndYear = 2016 };

        // job1.Display();

        // job2.Display();

        Resume resume1 = new Resume { Name = "Bryce Chesley" };
        resume1.Jobs.Add(job1);
        resume1.Jobs.Add(job2);
        resume1.Display();
    }
}