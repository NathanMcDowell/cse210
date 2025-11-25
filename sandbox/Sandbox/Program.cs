using System;

class Program
{
    static void Main(string[] args)
    {
        string animationString = "\\|/-";
        int sleepTime = 50;
        int duration = 10;
        int index = 0;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);
        
        // Console.CursorVisible = false;
        // while(DateTime.Now < endTime)
        // {
        //     Console.Write(animationString[index++ % animationString.Length]);
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b");
        // }
        // Console.CursorVisible = true;
        int count = duration;
        while(DateTime.Now < endTime)
        {
            Console.Write(count--);
            Thread.Sleep(1000);
            if (count >= 9)
                Console.Write("\b\b  \b\b");
            else
                Console.Write("\b");
        }
        
    }
}