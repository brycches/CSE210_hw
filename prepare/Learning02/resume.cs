public class Resume
{
    public string Name { get; set; }

    public List<Job> Jobs { get; set; } = new List<Job>();

    public Resume()
    {
        
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Jobs:");

        foreach (var jobDisplay in Jobs)
        {
            jobDisplay.Display();
        }
    }
};