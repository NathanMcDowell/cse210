using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new("red", 10);
        Rectangle rectangle = new("blue", 12, 7);

        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

    }
}