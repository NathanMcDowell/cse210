using System;

class Program
{
    static void Main(string[] args)
    {
        
        Characters characterList = new();
        Character character = new();

        characterList.AddCharacter(character);
        characterList.DisplayNames();
        Console.WriteLine(character.GetGeneralStats());     

        Menu menu = new();
        string userSelection = menu.ProcessMenu();
        do
        {
            switch (userSelection)
            {
                case "1":
                    Console.WriteLine("Create a Character");
                    break;
                case "2":
                    
                    break;
                case "3":

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