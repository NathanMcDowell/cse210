
class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }
    public void DisplayWord()
    {
        Console.Write($"{LocalGetWordString()} ");
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public void HideWord()
    {
        _isHidden = true;
    }
    private string LocalGetWordString()
    {
        if (!_isHidden)
        {
            return _word;
        } else
        {
            string blank = "";
            for (int i = 0; i < _word.Length; i++)
            {
                blank += "_";
            }
            return blank;
        }
    }
    public string GetWordString()
    {
        if (!_isHidden)
        {
            return _word;
        } else
        {
            string blank = "";
            for (int i = 0; i < _word.Length; i++)
            {
                blank += "_";
            }
            return blank;
        }
    }
}