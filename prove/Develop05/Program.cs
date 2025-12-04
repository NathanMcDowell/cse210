using System;
class Program
{
    static void Main(string[] args)
    {
        Menu goalMenu = new();
        UserData userData = new();
        string userSelection;
        string goalTypeSelection;
        int goalSelection;
        bool done = false;


        // SimpleGoal testSimpleGoal = new("s1", "des1", 100, false);
        // userData.AddEntry(testSimpleGoal);
        // EternalGoal testEternalGoal = new("e2", "des2", 120, false);
        // userData.AddEntry(testEternalGoal);
        // ChecklistGoal testChecklistGoal = new("c3", "yadayada", 7, false, 3, 8);
        // userData.AddEntry(testChecklistGoal);
        do
        {
            userSelection = goalMenu.ProcessMenu();
            Console.Clear();
            switch (userSelection)
            {
                // Create a goal
                case "1":
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    goalTypeSelection = Console.ReadLine();
                    Console.Clear();
                    switch (goalTypeSelection)
                    {
                        // Create a simple goal
                        case "1":
                            userData.AddEntry("SimpleGoal");
                            break;
                        // Create an eternal goal
                        case "2":
                            userData.AddEntry("EternalGoal");
                            break;
                        // Create a checklist goal
                        case "3":
                            userData.AddEntry("ChecklistGoal");
                            break;
                        default:
                            break;
                    }
                    
                    
                    break;
                // Display all goals
                case "2":
                    userData.Display();
                    
                    break;
                // Save to file
                case "3":
                    Console.Write("Enter filename to save to: ");
                    string saveFile = Console.ReadLine();
                    userData.SaveToFile(saveFile);
                    Console.WriteLine("Goals saved successfully!");
                    break;
                // Read from a file
                case "4":
                    Console.Write("Enter filename to load journal from: ");
                    string loadFile = Console.ReadLine();
                    //.ReadFromFile(loadFile);
                    Console.WriteLine("Goals loaded successfully!");
                    break;
                // Complete a goal
                case "5":
                    userData.Display();
                    Console.Write("Which goal did you complete? ");
                    goalSelection = int.Parse(Console.ReadLine());
                    userData.GetGoalList()[goalSelection - 1].RecordEvent(userData);
                    break;
                // Quit
                case "6":
                    done = true;
                    break;
                default:
                    break;
            }
        } while (!done);
    }
}
