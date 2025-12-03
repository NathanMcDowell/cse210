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
    public ChecklistGoal(string name, string description, int pointValue, int repGoal, int bonusPoints) 
    : base(name, description, pointValue)
    {
        _repGoal = repGoal;
        _bonusPoints = bonusPoints;
    }
    public override string DisplayGoal()
    {
        return $"{base.DisplayGoal()}, {_currentReps}/{_repGoal} to earn {_bonusPoints} bonus points";
    }
}