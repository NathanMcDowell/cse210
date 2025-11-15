
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
        foreach(Word word in _words)
        {
            word.DisplayWord();
        }
    }
}
