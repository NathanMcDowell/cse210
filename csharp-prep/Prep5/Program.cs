using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Hello Prep5 World!");
        }
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = Convert.ToInt16(Console.ReadLine());
            return number;
        }
        static void PromptUserBirthYear(out int year)
        {
            Console.Write("Please enter your birth year: ");
            year = Convert.ToInt16(Console.ReadLine());

        }
        static int SquareNumber(int number)
        {
            int sqrNumber = number * number;
            return sqrNumber;
        }
        static void DisplayResult(string name, int number, int year)
        {
            Console.WriteLine($"{name}, your number squared is {number}.");
            Console.WriteLine($"{name}, you will turn {2025 - year}");
        }
        DisplayWelcome();
        string name = PromptUserName();
        int number = SquareNumber(PromptUserNumber());
        int year;
        PromptUserBirthYear(out year);
        DisplayResult(name, number, year);
                
    }
}