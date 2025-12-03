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


        Goal testSimpleGoal = new("s1", "des1", 100);
        userData.AddEntry(testSimpleGoal);
        Goal testSimpleGoal2 = new("s2", "des2", 120);
        userData.AddEntry(testSimpleGoal2);
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
                    goalTypeSelection = Console.ReadLine();
                    Console.Clear();
                    switch (goalTypeSelection)
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
                    userData.Display();
                    Console.Write("Which goal did you complete? ");
                    goalSelection = int.Parse(Console.ReadLine());
                    userData.GetGoalList()[goalSelection - 1].RecordEvent(userData);
                    break;
                case "6":
                    // Quit
                    done = true;
                    break;
                default:
                    break;
            }
        } while (!done);
    }
}
