class Goal
{
    private string _name;
    private string _description;
    private int _pointValue;
    private bool _isComplete = false;

    public Goal(string name, string description, int pointValue)
    {
        _name = name;
        _description = description;
        _pointValue = pointValue;
    }
    public Goal()
    {
        Console.WriteLine("Goal Name: ");
        _name = Console.ReadLine();
        Console.WriteLine("Goal Description: ");
        _description = Console.ReadLine();
        Console.WriteLine("Point Value");
        _pointValue = int.Parse(Console.ReadLine());
    }
    public string DisplayGoal()
    {
        string completionIndicator = "";
        if (_isComplete == true)
        {
            completionIndicator = "X";
        }
        return $"[{completionIndicator}] {_name}: {_description}, {_pointValue} points";
    }
    public string CreateFileSystemString()
    {
        string outputString = "";
        outputString = $"{_name}#{_description}#{_pointValue}";
        return outputString;
    }
    virtual public bool IsComplete()
    {
        return _isComplete;
    }
    public void SetIsComplete(bool value)
    {
        _isComplete = value;
    }
    public int GetPointValue()
    {
        return _pointValue;
    }
    virtual public void RecordEvent(UserData userData)
    {
        userData.AddPoints(_pointValue);
        SetIsComplete(true);
        // Console.WriteLine("base goal record event done");
    }
}