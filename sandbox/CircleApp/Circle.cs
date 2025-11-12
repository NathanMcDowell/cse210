class Circle
{
    private double _radius;

    public Circle()
    {
        Console.WriteLine("Default");
        _radius = 0.0;
    }    

    public Circle(double radius)
    {
        SetRadius(radius);
    }
    
    public void SetRadius(double radius)
    {
        if (radius < 0)
        {
            Console.WriteLine("Invalid radius, must be >= 0.0");
            _radius = 0;
        }
        else
        {
            _radius = radius;
        }
    }

    public double GetCircleArea()
    {
        return 3.1415 * _radius * _radius;
    }
}