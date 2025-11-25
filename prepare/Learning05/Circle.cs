class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius)
    : base(color)
    {
        _radius = radius;
    }
    override public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}