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
        menu.ProcessMenu();

    }
}