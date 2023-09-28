public class Job
{
    public string Company { get; set; }

    public string JobTitle { get; set; }

    public int StartYear { get; set; }

    public int EndYear { get; set; }

    public Job()
    {
        
    }

    public void Display()
    {
        Console.WriteLine($"Company: {Company} Job title: {JobTitle} Start year: {StartYear} End year: {EndYear}");
    }
    
};