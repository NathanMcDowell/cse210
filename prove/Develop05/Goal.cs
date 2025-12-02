class Goal
{
    private string _name;
    private string _description;
    private int _pointValue;

    // public Goal(string name, string description, int pointValue)
    // {
    //     _name = name;
    //     _description = description;
    //     _pointValue = pointValue;
    // }
    public Goal()
    {
        Console.WriteLine("Goal Name: ");
        _name = Console.ReadLine();
        Console.WriteLine("Goal Description: ");
        _description = Console.ReadLine();
        Console.WriteLine("Point Value");
        _pointValue = int.Parse(Console.ReadLine());
    }
    public void DisplayGoal()
    {
        Console.WriteLine($"{_name}: {_description}, {_pointValue} points");
    }
}