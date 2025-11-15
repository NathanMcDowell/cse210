
class Reference
{
    private string _bookName;
    private int _chapter;
    private string _verses;

    public Reference(string bookName, int chapter, int startVerse, int endVerse)
    {
        _bookName = bookName;
        _chapter = chapter;
        _verses = startVerse + "-" + endVerse;
    }
    public Reference(string bookName, int chapter, int startVerse)
    {
        _bookName = bookName;
        _chapter = chapter;
        _verses = startVerse.ToString();
    }
    public void Display()
    {
        Console.WriteLine($"{_bookName} {_chapter}: {_verses}");
    }
}