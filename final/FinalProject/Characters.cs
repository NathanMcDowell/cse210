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
}