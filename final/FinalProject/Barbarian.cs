class Barbarian : Martial
{
    public Barbarian() : base()
    {
        int dexMod = GetAbilityMods()[1];
        int conMod = GetAbilityMods()[2];
        
        int shieldArmor = 0;
        if (UserSetUsingShield() == true)
        {
            shieldArmor = 2;
        }
        SetArmorClass(10 + dexMod + conMod + shieldArmor);
    }
    public Barbarian(string name, string characterClass, int maxHealth, List<int> abilityScores, string weapon, bool usingShield) 
    : base(name, characterClass, maxHealth, abilityScores, weapon, usingShield)
    {
        int dexMod = GetAbilityMods()[1];
        int conMod = GetAbilityMods()[2];
        int shieldArmor = 0;
        if (usingShield == true)
        {
            shieldArmor = 2;
        }
        SetArmorClass(10 + dexMod + conMod + shieldArmor);
    }
}