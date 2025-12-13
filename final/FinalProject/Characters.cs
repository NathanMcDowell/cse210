class Characters
{
    private List<Character> _characterList = [];
    

    public string DisplayNames()
    {
        int count = 1;
        Console.WriteLine();
        foreach(Character character in _characterList)
        {
            Console.WriteLine($"{count}. {character.GetName()} the {character.GetClass()}");
            count++;
        }
        Console.WriteLine("Input a number: ");
        string userSelection = Console.ReadLine();
        return userSelection;
    }
    public void AddCharacter(Character character)
    {
        _characterList.Add(character);
    }
    public void AddCharacter(string classChoice)
    {
        switch (classChoice)
        {
            case "Barbarian":
                Barbarian barbarian = new();
                _characterList.Add(barbarian);
                break;
            case "Fighter":
                Fighter fighter = new();
                _characterList.Add(fighter);
                break;
            case "Cleric":
                Cleric cleric = new();
                _characterList.Add(cleric);
                break;
            case "Wizard":
                Wizard wizard = new();
                _characterList.Add(wizard);
                break;
        }
    }
    public void DisplayCharacterList()
    {
        foreach(Character character in _characterList)
        {
            Console.WriteLine($"{character.GetGeneralStats()}, AC: {character.GetArmorClass()}, Shield: {character.GetUsingShield()}, Armor: {character.GetArmorType()}");
        }
    }
    public void DisplayCharacterInventory(int index)
    {
        
        int currentIndex = 0;
        foreach(Character character in _characterList)
        {
            if (currentIndex == index)
            {
                List<Item> inventory = character.GetInventory();
                foreach(Item item in inventory)
                {
                    Console.WriteLine(item.GetItem());
                }
                break;
            } else
            {
                currentIndex++;
            }
        }
    }
    public void UpdateCharacterInventory(int index, string item, int quantity)
    {
        Character character = _characterList[index];
        bool inInventory = false;
        foreach(Item i in character.GetInventory())
        {
            if (i.GetName() == item)
            {
                inInventory = true;
                i.ModifyQuantity(quantity);
                break;
            }
        }
        if (!inInventory)
        {
            Item newItem = new(item, quantity);
            character.GetInventory().Add(newItem);
        }
    }
}