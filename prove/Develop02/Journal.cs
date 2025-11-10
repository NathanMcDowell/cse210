
class Journal
{
    public void Display()
    {

    }
    public void AddEntry(JournalEntry entry)
    {

    }
    public void SaveToFile()
    {
        
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