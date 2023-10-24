class Scripture
{
    private string reference;
    private List<Word> words;

    public bool AllWordsHidden => words.All(word => word.Hidden);

    public Scripture(string reference)
    {
        this.reference = reference;
        this.words = new List<Word>();
        string scriptureText = GetScriptureText(reference);


        string[] textWords = scriptureText.Split(' ');
        foreach (string word in textWords)
        {
            words.Add(new Word(word));
        }
    }

    private string GetScriptureText(string reference)
    {

        if (reference == "John 3:16")
        {
            return "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        }
        else
        {
            return null;
        }
    }

    public void HideRandomWord(Random random)
    {
        if (!AllWordsHidden)
        {
            Word wordToHide;
            do
            {
                int randomIndex = random.Next(0, words.Count);
                wordToHide = words[randomIndex];
            } while (wordToHide.Hidden);

            wordToHide.HideWord();
        }
    }

    public string GetHiddenText()
    {
        List<string> hiddenWords = words.Select(word => word.Hidden ? new string('_', word.Text.Length) : word.Text).ToList();
        return $"{reference} {string.Join(" ", hiddenWords)}";
    }
}