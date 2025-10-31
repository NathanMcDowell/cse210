using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Input a grade percentage: ");
        string percent;
        percent = Console.ReadLine();
        float intPercent = Convert.ToInt32(percent);
        string letter = "";
        if (intPercent >= 90)
        {
            letter = "A";
        }
        else if (intPercent >= 80)
        {
            letter = "B";
        }
        else if (intPercent >= 70)
        {
            letter = "C";
        }
        else if (intPercent >= 60)
        {
            letter = "D";
        }
        else if (intPercent < 60)
        {
            letter = "D";
        }
        Console.WriteLine($"Your grade is {letter}");
        if (intPercent >= 70)
        {
            Console.WriteLine("You pass!");
        }
    }
}