
class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        Circle myCircle = new Circle();

        myCircle.SetRadius(10);

        Console.WriteLine(myCircle.GetCircleArea());

        Circle myCircle2 = new Circle(200);
        Console.WriteLine(myCircle2.GetCircleArea());
    }
}

