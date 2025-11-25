class Program
{
    static void PassByValue(int x)
    {
        x = 1001;
        Console.WriteLine($"In this function, x is: {x}");
    }
    static void PassByReference(ref int a)
    {
        a = 19999;
        Console.WriteLine($"In this function, a is: {a}");
    }
    static void PassByOut(out int a)
    {
        a = 19;
        Console.WriteLine($"In this function, a is: {a}");
    }
    static void PassReferenceType(int [] data)
    {
        data[3] = 12345;
        Console.WriteLine($"In the RT function, data[3] is: {data[3]}");
    }
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello there");
        int x = 10;
        int y = x;
        y++;
        Console.WriteLine($"{x}, {y}");

        int [] a = [1,2,3,4,5];
        int [] b = a;

        b[3] = 111;
        Console.WriteLine($"{a[3]} - {b[3]}");

        PassByValue(x);
        Console.WriteLine($"In main, x is: {x}");
        
        PassByReference(ref x);
        Console.WriteLine($"In main, x is: {x}");
        
        int z;
        PassByOut(out z);
        Console.WriteLine($"In main, x is: {z}");
            
        PassReferenceType(a);
        foreach (int i in a)
        {
            Console.WriteLine($"In main, i is: {i}");
        }
    }
}
