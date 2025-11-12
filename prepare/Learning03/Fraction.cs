class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }
    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }

    public void GetTop(){Console.WriteLine(_numerator);}
    public void GetBottom(){Console.WriteLine(_denominator);}
    public void SetTop(int top) { _numerator = top; }
    public void SetBottom(int bottom) { _denominator = bottom; }

    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / (double)_denominator;
    }
}