class Menu
{
    public string[] _menuStrings =
    {
        "You can create, display, save, and read goals",
        "1 - Create Character",
        "2 - Display Character Stats",
        "3 - Display Character Inventory",
        "4 - Update Inventory",
        "5 - Deal Damage",
        "6 - Quit"
    };

    /* Process Menu will display the menu to the user and read and validate the unput
    and return the input. There are no parameters received in this function */

    public string ProcessMenu()
    {
        string userSelection;
        foreach (string menuItem in _menuStrings)
        {
            Console.WriteLine(menuItem);
        }
        userSelection = Console.ReadLine();
        return userSelection;
    }
}