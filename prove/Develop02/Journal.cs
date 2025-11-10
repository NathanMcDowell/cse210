
class Journal
{
    List<JournalEntry> _entries = new List<JournalEntry>();
    
    public void Display()
    {
        foreach(JournalEntry entry in _entries)
        {
            entry.Display();
        }
    }
    public void AddEntry(JournalEntry entry)
    {
        _entries.Add(entry);
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
    {
        foreach (JournalEntry entry in _entries)
        {
            // Write one line per entry, separating parts with '#'
            outputFile.WriteLine($"{entry._date}#{entry._entryQuestion}#{entry._journalEntry}");
        }
    }
    }
    public void ReadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("#");

            string date = parts[0];
            string question = parts[1];
            string entryText = parts[2];

            JournalEntry entry = new JournalEntry();
            entry.CreateJournalEntry(date, question, entryText);
            this.AddEntry(entry);
        }
    }
    
}