using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();
        
        
        int newNumber = 0;
        do
        {
            Console.Write("Enter a number: ");
            newNumber = Convert.ToInt32(Console.ReadLine());
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            }
        } while (newNumber != 0);
        foreach (int number in numbers)
        {
        Console.WriteLine(number);
        }
        
        
    }
}