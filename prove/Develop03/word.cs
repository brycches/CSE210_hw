class Word
{
    public string Text { get; private set; }
    public bool Hidden { get; private set; }

    public Word(string text)
    {
        Text = text;
        Hidden = false;
    }

    public void HideWord()
    {
        if (!Hidden)
        {
            Hidden = true;
            Text = new string('_', Text.Length);
        }
    }
}