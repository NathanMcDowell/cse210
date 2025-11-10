
class JournalEntry
{
    public string _date;
    public string _entryQuestion;
    public string _journalEntry;
    Random random = new Random();
    List<string> entryQuestions = new List<string>{
        "Did you have a good day?",
        "What did you eat for breakfast?",
        "How did you see the hand of God in your life today?",
        "What did you think of the weather today?"};
    public void Display()
    {
        Console.WriteLine($"{_date}- {_entryQuestion}: {_journalEntry}");
    }
    public void CreateJournalEntry()
    {
        _date = "11/10/2025";
        _entryQuestion = entryQuestions[random.Next(0, 4)];
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