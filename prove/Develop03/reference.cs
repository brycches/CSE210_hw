class ScriptureReference
{
    public int StartVerse { get; }
    public int EndVerse { get; }

    public ScriptureReference(string reference)
    {
        string[] parts = reference.Split(':');
        string versePart = parts[1];
        if (versePart.Contains('-'))
        {
            string[] verses = versePart.Split('-');
            StartVerse = int.Parse(verses[0]);
            EndVerse = int.Parse(verses[1]);
        }
        else
        {
            StartVerse = int.Parse(versePart);
            EndVerse = StartVerse;
        }
    }
}