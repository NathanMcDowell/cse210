class SpellCaster : Character
{
    private string _focus;
    public SpellCaster() : base()
    {
        Console.Write("Spellcasting Focus: ");
        _focus = Console.ReadLine();
    }
    public SpellCaster(string name, string characterClass, int maxHealth, List<int> abilityScores, string focus, bool usingShield) 
    : base(name, characterClass, maxHealth, abilityScores)
    {
        _focus = focus;
        SetUsingShield(usingShield);
    }
    public override string GetGeneralStats()
    {
        return $"{base.GetGeneralStats()}, Spell Focus: {_focus}";
    }
}