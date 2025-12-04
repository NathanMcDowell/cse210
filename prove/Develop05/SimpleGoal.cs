class SimpleGoal : Goal
{
    public SimpleGoal() 
    : base(){}
    public SimpleGoal(string name, string description, int pointValue, bool isComplete) 
    : base(name, description, pointValue, isComplete){}

    public override string CreateFileSystemString()
    {
        return $"SimpleGoal#{base.CreateFileSystemString()}";
    }
}