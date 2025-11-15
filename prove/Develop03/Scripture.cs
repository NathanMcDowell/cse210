
class Scripture
{
    private List<Word> _words = [];
    private Reference _reference;

    public Scripture(string bookName, int chapter, int startVerse, int endVerse, string scriptureText)
    {
        _reference = new Reference(bookName, chapter, startVerse, endVerse);
        string[] splitWords = scriptureText.Split(" ");

        foreach(string word in splitWords)
        {
            Word entry = new Word(word);
            _words.Add(entry);
        }
    }
    public Scripture(string bookName, int chapter, int startVerse, string scriptureText)
    {
        _reference = new Reference(bookName, chapter, startVerse);
        string[] splitWords = scriptureText.Split(" ");

        foreach(string word in splitWords)
        {
            Word entry = new Word(word);
            _words.Add(entry);
        }
    }

    public void Display()
    {
        _reference.Display();
        foreach (Word word in _words)
        {
            word.DisplayWord();
        }
    }
    public bool HideWords()
    {
        Random random = new Random();
        int index;
        int i = 0;
        int hiddenCount = 0;
        while (i < 3)
        {
            if (hiddenCount > _words.Count - 3)
            {
                foreach (Word word in _words)
                {
                    word.Hide();
                }
                return false;
            }

            index = random.Next(0, _words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                i++;
            }
            hiddenCount = 0;
            foreach (Word word in _words)
            {
                if (word.IsHidden())
                {
                    hiddenCount++;
                }
            }

        }
        return true;
    }
}
