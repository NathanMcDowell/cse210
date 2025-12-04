class ChecklistGoal : Goal
{
    private int _repGoal;
    private int _currentReps = 0;
    private int _bonusPoints;
    ChecklistGoal() : base()
    {
        Console.WriteLine("How many times should this goal be completed for a bonus? ");
        _repGoal = int.Parse(Console.ReadLine());
        Console.WriteLine("How many points is the bonus prize? ");
        _bonusPoints = int.Parse(Console.ReadLine());
        
    }
    public ChecklistGoal(string name, string description, int pointValue, bool isComplete, int repGoal,  int bonusPoints, int currentReps = 0) 
    : base(name, description, pointValue, isComplete)
    {
        _repGoal = repGoal;
        _bonusPoints = bonusPoints;
        _currentReps = currentReps;
    }
    public override string DisplayGoal()
    {
        return $"{base.DisplayGoal()}, {_currentReps}/{_repGoal} to earn {_bonusPoints} bonus points";
    }
    public override void RecordEvent(UserData userData)
    {
        base.RecordEvent(userData);
        _currentReps++;
        if (_currentReps == _repGoal)
        {
            userData.AddPoints(_bonusPoints);
        }
        if(_currentReps >= _repGoal)
        {
            SetIsComplete(true);
        } else
        {
            SetIsComplete(false);
        }
    }
    public override string CreateFileSystemString()
    {
        return $"ChecklistGoal#{base.CreateFileSystemString()}#{_currentReps}#{_repGoal}#{_bonusPoints}#{_currentReps}";
    }
}