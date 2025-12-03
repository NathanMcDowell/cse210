class EternalGoal : Goal
{
    EternalGoal() : base(){}
    public EternalGoal(string name, string description, int pointValue) 
    : base(name, description, pointValue){}
    public override void RecordEvent(UserData userData)
    {
        base.RecordEvent(userData);
        SetIsComplete(false);
        // Console.WriteLine("eternal goal record event done");
    }
}