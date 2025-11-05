using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        // Here to test if everything is working
        // Console.WriteLine(magicNumber);
        int guessNumber = 0;
        int guessCount = 0;
        do
        {
            Console.Write("Guess a number between 1 and 100: ");
            guessNumber = Convert.ToInt16(Console.ReadLine());
            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Guess lower!");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Guess higher!");
            }
            guessCount++;
        } while (guessNumber != magicNumber);
        Console.WriteLine("That's the one!");
        Console.WriteLine($"It took you {guessCount} guesses.");
    }
}