using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");

        Activity activity = new("Super Duper", "A really cool activity");

        int response = 0;
        while (response != 4)
        {
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");

            response = int.Parse(Console.ReadLine());
            
            if (response == 1)
            {
               activity.DisplayGreeting();
               activity.DisplayDescription();
            }
        }
    }
}