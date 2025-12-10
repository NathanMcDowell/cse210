using System;

class Program
{
    static void Main(string[] args)
    {
        
        Characters characterList = new();
        List<string> classes = 
        ["1 - Barbarian", 
        "2 - Fighter", 
        "3 - Cleric", 
        "4 - Wizard"];

        Barbarian testBarbarian = new("John", "Barbarian", 30, [16,15,14,13,12,11], "Axe");
        Item item = new("Cool Hat", 1);
        testBarbarian.AddItem(item);
        characterList.AddCharacter(testBarbarian); 

        Menu menu = new();
        string userSelection;
        do
        {
            userSelection = menu.ProcessMenu();
            switch (userSelection)
            {
                case "1":
                    Console.WriteLine("Create a Character");
                    Console.WriteLine();
                    foreach(string classOption in classes)
                        {
                            Console.WriteLine($"{classOption}");
                        }
                    Console.WriteLine("What class will your new character be?");
                    userSelection = Console.ReadLine();
                    switch (userSelection)
                        {
                            case "1":
                                characterList.AddCharacter("Barbarian");
                            break;
                            case "2":
                                characterList.AddCharacter("Fighter");
                            break;
                            case "3":
                                characterList.AddCharacter("Cleric");
                            break;
                            case "4":
                                characterList.AddCharacter("Wizard");
                            break;
                            default:
                                Console.WriteLine("Give a proper input, please.");
                                break;
                        }
                    break;
                case "2":
                    characterList.DisplayCharacterList();
                    break;
                case "3":
                    characterList.DisplayNames();
                    Console.Write("Who's inventory do you want to see? ");
                    userSelection = Console.ReadLine();
                    characterList.DisplayCharacterInventory(int.Parse(userSelection)-1);
                    break;
                case "4":

                    break;
                case "5":

                    break;
                case "6":

                    break;
                default:
                    Console.WriteLine("Give a proper input, please.");
                    break;
            }
        } while(userSelection != "6");

    }
}