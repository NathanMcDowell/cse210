using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers = new List<int>();


        int newNumber;
        int largestNumber = 0;
        int smallestPositive = 0;
        do
        {
            Console.Write("Enter a number: ");
            newNumber = Convert.ToInt32(Console.ReadLine());
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
                if (newNumber > largestNumber)
                {
                    largestNumber = newNumber;
                }
                foreach (int number in numbers)
                {
                    if (newNumber <= number && newNumber > 0)
                    {
                        if (newNumber <= smallestPositive || smallestPositive == 0)
                        {
                            smallestPositive = newNumber;
                        }
                            
                    }   
                }
                
            }
        } while (newNumber != 0);

        float total = 0;

        foreach (int number in numbers)
        {
            total += number;
        }
        float average = total / numbers.Count;
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        
        
        
    }
}