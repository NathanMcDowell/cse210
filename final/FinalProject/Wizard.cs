class Wizard : SpellCaster
{
    public Wizard() : base()
    {
        int dexMod = GetAbilityMods()[1];
        SetArmorType("None");
        SetArmorClass(10 + dexMod);
    }
    public Wizard(string name, string characterClass, int maxHealth, List<int> abilityScores, string focus) 
    : base(name, characterClass, maxHealth, abilityScores, focus, false)
    {
        int dexMod = GetAbilityMods()[1];
        SetArmorType("None");
        SetArmorClass(10 + dexMod);
    }
}