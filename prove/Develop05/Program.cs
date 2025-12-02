using System;
class Program
{
    static void Main(string[] args)
    {
        Menu journalMenu = new();
        UserData userData = new();
        string userSelection;

        bool done = false;

        do
        {
            userSelection = journalMenu.ProcessMenu();
            switch (userSelection)
            {
                case "1":
                    // Create a new Entry Object
                    // Call create an that object
                    // Add the entry to the journal
                    Goal goal = new("Don't die", "It is a good idea", 100000);
                    userData.AddEntry(goal);
                    userData.Display();
                    break;
                case "2":
                    
                    break;
                case "3":
                    Console.Write("Enter filename to save to: ");
                    string saveFile = Console.ReadLine();
                    //.SaveToFile(saveFile);
                    Console.WriteLine("Journal saved successfully!");
                    break;

                case "4":
                    // Read from a file
                    Console.Write("Enter filename to load journal from: ");
                    string loadFile = Console.ReadLine();
                    //.ReadFromFile(loadFile);
                    Console.WriteLine("Journal loaded successfully!");
                    break;
                case "5":
                // Quit
                    done = true;
                    break;
                default:
                    break;
            }
        } while (!done);
    }
}
