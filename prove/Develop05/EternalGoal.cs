class EternalGoal : Goal
{
    public EternalGoal() : base(){}
    public EternalGoal(string name, string description, int pointValue, bool isComplete) 
    : base(name, description, pointValue, isComplete){}
    public override void RecordEvent(UserData userData)
    {
        base.RecordEvent(userData);
        SetIsComplete(false);
        // Console.WriteLine("eternal goal record event done");
    }
    public override string CreateFileSystemString()
    {
        return $"EternalGoal#{base.CreateFileSystemString()}";
    }
}