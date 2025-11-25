using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = [];
        shapes.Add(new Square("red", 10));
        shapes.Add(new Rectangle("blue", 12, 7));
        shapes.Add(new Square("green", 5));

        foreach(Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()}, {shape.GetArea()}");
        }

    }
}