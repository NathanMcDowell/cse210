class Martial : Character
{
    private string _weapon;
    public Martial() : base()
    {
        Console.Write("Weapon: ");
        _weapon = Console.ReadLine();
    }
    public Martial(string name, string characterClass, int maxHealth, List<int> abilityScores, string weapon) 
    : base(name, characterClass, maxHealth, abilityScores)
    {
        _weapon = weapon;
    }
    public override string GetGeneralStats()
    {
        return $"{base.GetGeneralStats()}, Wielding: {_weapon}";
    }
}