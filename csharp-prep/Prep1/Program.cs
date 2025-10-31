using System;

class Program
{
    static void Main(string[] args)
    {
        // This is my C# Prep 1 code.
        Console.WriteLine("Hello Sandbox World!");
        string firstName;
        string lastName;

        Console.Write("Please enter your first name: ");
        firstName = Console.ReadLine();
        Console.Write("Please enter your last name: ");
        lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");

        int x = 10;

        if (!(x == 10 || x == 12 && x == 13 && x != 23))
        {
            Console.WriteLine("X == 10");
        }
        else if (x == 435)
        {
            Console.WriteLine("Hey Bob");
        }

        Console.WriteLine("X is who knows what?");
    }
}