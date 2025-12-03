class UserData
{
    private List<Goal> _goals = [];
    private int _totalPoints = 0;
    
    public void Display()
    {
        int count = 1;
        foreach(Goal goal in _goals)
        {
            Console.WriteLine($"{count}. {goal.DisplayGoal()}");
            count++;
        }
        Console.WriteLine();
        Console.WriteLine($"Total Points: {_totalPoints}");
        Console.WriteLine();
    }
    public void AddEntry(Goal goal)
    {
        _goals.Add(goal);
    }
    public void AddPoints(int points)
    {
        _totalPoints += points;
    }
    public List<Goal> GetGoalList()
    {
        return _goals;
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