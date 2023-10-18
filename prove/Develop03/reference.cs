public class reference
{
    private string _reference;
    private int _parsedReference;

    public string GetReference()
    {
        return _reference;
    }

    public void SetReference(string reference)
    {
        _reference = reference;
    }

    public List<int> ParseReference()
    {
        _parsedReference.Clear();

        // Assuming the reference is in the format "Book Chapter:Verse[-Verse]"
        // We'll split the reference and extract chapter and verse numbers.

        if (!string.IsNullOrEmpty(_reference))
        {
            string[] parts = _reference.Split(' ');
            if (parts.Length == 2)
            {
                string[] chapterVerse = parts[1].Split(':');
                if (chapterVerse.Length == 2)
                {
                    string[] verseRange = chapterVerse[1].Split('-');
                    if (int.TryParse(chapterVerse[0], out int chapter))
                    {
                        if (verseRange.Length == 2)
                        {
                            if (int.TryParse(verseRange[0], out int startVerse) &&
                                int.TryParse(verseRange[1], out int endVerse))
                            {
                                for (int verse = startVerse; verse <= endVerse; verse++)
                                {
                                    _parsedReferences.Add(chapter * 1000 + verse); // Combine chapter and verse into a single integer
                                }
                            }
                        }
                        else if (int.TryParse(chapterVerse[1], out int verse))
                        {
                            _parsedReferences.Add(chapter * 1000 + verse); // Combine chapter and verse into a single integer
                        }
                    }
                }
            }
        }

        return _parsedReferences;
    }
}
