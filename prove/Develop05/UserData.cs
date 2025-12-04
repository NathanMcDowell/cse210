class UserData
{
    private List<Goal> _goals = [];
    private int _totalPoints = 0;
    
    public void Display()
    {
        int count = 1;
        Console.WriteLine();
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
            outputFile.WriteLine(goal.CreateFileSystemString());
        }
    }
    }
    public void ReadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            
            string[] parts = line.Split("#");
            
            if (parts[0] == "SimpleList")
            {
                string name = parts[1];
                string description = parts[2];
                int pointValue = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);
                SimpleGoal goal = new(name, description, pointValue, isComplete);
                AddEntry(goal);
            }
            if (parts[0] == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int pointValue = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);
                EternalGoal goal = new(name, description, pointValue, isComplete);
                AddEntry(goal);
            }
            if (parts[0] == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                int pointValue = int.Parse(parts[3]);
                bool isComplete = bool.Parse(parts[4]);
                int repGoal = int.Parse(parts[5]);
                int bonusPoints = int.Parse(parts[6]);
                int currentReps = int.Parse(parts[7]);
                ChecklistGoal goal = new(name, description, pointValue, isComplete, repGoal, bonusPoints, currentReps);
                AddEntry(goal);
            }
            // JournalEntry entry = new JournalEntry();
            // entry.CreateJournalEntry(date, question, entryText);
            // this.AddEntry(entry);
        }
    }
    
}