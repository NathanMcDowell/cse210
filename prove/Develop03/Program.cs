using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!");
        string scriptureText = @"Brethren, shall we not go on in so great a cause? Go forward and not backward. Courage, brethren; and on, on to the victory! Let your hearts rejoice, and be exceedingly glad. Let the earth break forth into singing. Let the dead speak forth anthems of eternal praise to the King Immanuel, who hath ordained, before the world was, that which would enable us to redeem them out of their prison; for the prisoners shall go free.";

        Scripture scripture = new Scripture("Doctrine and Covenants", 128, 22, scriptureText);
        Console.WriteLine("scripture initialized");
        
        bool running = true;
        do
        {
            scripture.Display();
            Console.WriteLine();
            string input = Console.ReadLine();
            if (input != "")
            {
                running = false;
            }
            scripture.HideWords();
        } while (running);
        
    }
}