class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    private DateTime _endTime;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }
    public void DisplayGreeting()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
    }
    public void DisplayDescription()
    {
        Console.WriteLine(_description);
    }
    public void DisplayEnding()
    {
        Console.WriteLine("Thank you for participating!");
    }
    public void RunCountDown(string message, int seconds)
    {
        Console.WriteLine(message);
        
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(seconds);
        
        Console.CursorVisible = false;
        DisplaySpinner("\\|/-", endTime);
        Console.CursorVisible = true;
    }
    public void DisplaySpinner(string animation, DateTime endTime)
    {
        int index = 0;
        while(DateTime.Now < endTime)
        {
        Console.Write(animation[index++ % animation.Length]);
        Thread.Sleep(50);
        Console.Write("\b");
        }
        
        
    }
    public void StartTimer()
    {
        
    }
    // public bool HasTimerExpired()
    // {
        
    // }
    public DateTime ObtainDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        DateTime currentTime = DateTime.Now;
        _endTime = currentTime.AddSeconds(_duration);
        return _endTime;
    }
    // public string GetPromptString(List<FlaggedString>)
    // {

    // }
}