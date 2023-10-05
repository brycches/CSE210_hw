public class Journal
{
    public string Name { get; set; }
    public List<Entry> Entries { get; set; }

    public Journal() 
    {
        Entries = new List<Entry>();
    } 
}