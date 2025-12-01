using System.Threading.Tasks.Dataflow;

class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description)
    : base(name, description){}

    public void RunActivity()
    {
        Console.Clear();
        DisplayGreeting();
        DisplayDescription();
        DateTime endTime = ObtainDuration();

        Console.Clear();
        RunCountDown("Get ready... ", 5);

        Console.Clear();
        while(DateTime.Now < endTime)
        {
            RunCountDown("Breath in ", 4);
            Console.Clear();
            RunCountDown("Breath out ", 6);
            Console.Clear();
        }
        Console.Clear();
        DisplayEnding();
        DisplaySpinner("\\|/-", 5);
    }
}