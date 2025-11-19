using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        MathAssignment assignment = new MathAssignment("John", "Math", "Section 5", "Problems 9-15");
        Console.WriteLine(assignment.GetHomeworkList());
        WritingAssignment assignment2 = new WritingAssignment("Steven", "Average English", "The Okay Gatsby");
        Console.WriteLine(assignment2.GetWritingInformation());
    }
}