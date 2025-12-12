class Martial : Character
{
    private string _weapon;
    public Martial() : base()
    {
        Console.Write("Weapon: ");
        _weapon = Console.ReadLine();
    }
    public Martial(string name, string characterClass, int maxHealth, List<int> abilityScores, string weapon, bool usingShield) 
    : base(name, characterClass, maxHealth, abilityScores)
    {
        _weapon = weapon;
        SetUsingShield(usingShield);
    }
    public override string GetGeneralStats()
    {
        return $"{base.GetGeneralStats()}, Wielding: {_weapon}";
    }
}