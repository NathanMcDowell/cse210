using System;
class Program
{
    static void Main(string[] args)
    {
        Menu goalMenu = new();
        UserData userData = new();
        string userSelection;
        string goalSelection;
        bool done = false;

        do
        {
            userSelection = goalMenu.ProcessMenu();
            Console.Clear();
            switch (userSelection)
            {
                case "1":
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    goalSelection = Console.ReadLine();
                    Console.Clear();
                    switch (goalSelection)
                    {
                        case "1":
                            SimpleGoal goal = new();
                            userData.AddEntry(goal);
                            goal.RecordEvent(userData);
                            
                            break;
                        case "2":
                            
                            break;

                        case "3":

                            break;

                        default:

                            break;
                    }
                    
                    
                    break;
                case "2":
                    userData.Display();
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
