using System;

class Program
{
    static void TestValues(int x, double y, double z)
    {
        Console.WriteLine($"The values are {x}, {y}, {z}");
    }
    static int AddValues(int n1, int n2, int n3)
    {
        int total = n1 + n2 + n3;
        return total;
    }
    static void Main(string[] args)
    {
        TestValues(10, 5.4, 2.33);
        int total = AddValues(10, 20, 30);
        Console.WriteLine($"The total is {total}.");
        /*// Console.WriteLine("Hello Sandbox World!");
        // string firstName;
        // string lastName;

        // Console.Write("Please enter your first name: ");
        // firstName = Console.ReadLine();
        // Console.Write("Please enter your last name: ");
        // lastName = Console.ReadLine();

        // Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");

        // int x = 10;

        // if (!(x == 10 || x == 12 && x == 13 && x != 23))
        // {
        //     Console.WriteLine("X == 10");
        // }
        // else if (x == 435)
        // {
        //     Console.WriteLine("Hey Bob");
        // }
        // Console.WriteLine("X is who knows what?");
        // Console.WriteLine(Math.Pow(2, 10));
        // Console.WriteLine($"{x}, {++x}, {x++}, {x}");

        // for (int i = -1000; i <= 1000; i+=100)
        // {
        //     Console.WriteLine($"The value of i is {i}");
        // }

        // bool done = false;

        // do
        // {
        //     Console.Write("Input your age: ");
        //     int age = int.Parse(Console.ReadLine());
        //     if (age >= 0 && age <= 125)
        //     {
        //         done = true;
        //         Console.WriteLine($"Super age: {age}");
        //     }

        // } while (!done);

        // List<int> numbers = new List<int>();
        // numbers.Add(10);
        // numbers.Add(100);
        // numbers.Add(74);
        // foreach(int n in numbers)
        // {
        //     Console.WriteLine($"The number is {n}");
        // }*/
        
    }
}