class UserData
{
    private List<Goal> _goals = [];
    private int _totalPoints = 0;
    
    public void Display()
    {
        foreach(Goal goal in _goals)
        {
            goal.DisplayGoal();
        }
        Console.WriteLine($"Total Points: {_totalPoints}");
    }
    public void AddEntry(Goal goal)
    {
        _goals.Add(goal);
    }
    public void AddPoints(int points)
    {
        _totalPoints += points;
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