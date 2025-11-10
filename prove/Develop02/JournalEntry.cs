
class JournalEntry
{
    public string _date;
    public string _entryQuestion;
    public string _journalEntry;

    public void Display()
    {
        Console.WriteLine($"{_date}- {_entryQuestion}: {_journalEntry}");
    }
    public void CreateJournalEntry()
    {
        _date = "11/10/2025";
        _entryQuestion = "How are you doing?";
        Console.Write(_entryQuestion);
        _journalEntry = Console.ReadLine();
            }
    public void CreateJournalEntry(string date, string prompt, string response)
    {

    }
    public string CreateFileSystemString()
    {
        string outputString = "";
        outputString = $"{_date}#{_entryQuestion}#{_journalEntry}";
        return outputString;
    }
    
}