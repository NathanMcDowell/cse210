using System.Threading.Tasks.Dataflow;

class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description)
    : base(name, description){}

    public void RunActivity()
    {
        DisplayGreeting();
        DisplayDescription();
        DateTime endTime = ObtainDuration();
        RunCountDown("Get ready...", 5);
        
        while(DateTime.Now < endTime)
        {
            RunCountDown("Breath in", 5);
            RunCountDown("Breath out", 5);
        }
    }
}