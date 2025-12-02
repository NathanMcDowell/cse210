class UserData
{
    List<Goal> _goals = [];
    
    public void Display()
    {
        foreach(Goal goal in _goals)
        {
            goal.DisplayGoal();
        }
    }
    public void AddEntry(Goal goal)
    {
        _goals.Add(goal);
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
    {
        foreach (Goal goal in _goals)
        {
            // Write one line per entry, separating parts with '#'
            // outputFile.WriteLine(goal.CreateFileSystemString());
        }
    }
    }
    // public void ReadFromFile(string filename)
    // {
    //     string[] lines = System.IO.File.ReadAllLines(filename);

    //     foreach (string line in lines)
    //     {
    //         string[] parts = line.Split("#");

    //         string date = parts[0];
    //         string question = parts[1];
    //         string entryText = parts[2];

    //         JournalEntry entry = new JournalEntry();
    //         entry.CreateJournalEntry(date, question, entryText);
    //         this.AddEntry(entry);
    //     }
    // }
    
}