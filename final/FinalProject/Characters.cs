class Characters
{
    private List<Character> _characterList = [];
    

    public void DisplayNames()
    {
        int count = 1;
        Console.WriteLine();
        foreach(Character character in _characterList)
        {
            Console.WriteLine($"{count}. {character.GetName()} the {character.GetClass()}");
            count++;
        }
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
            Console.WriteLine(character);
        }
    }
}