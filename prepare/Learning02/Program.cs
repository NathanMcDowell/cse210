using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2020;
        job1._endYear = 2025;
        Job job2 = new Job();
        job2._jobTitle = "Cybersecurity";
        job2._company = "Apple";
        job2._startYear = 2015;
        job2._endYear = 2022;
        Console.WriteLine(job1._company);
        Console.WriteLine(job2._company);
    }
     
}