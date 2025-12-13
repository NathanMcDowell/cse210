class Cleric : SpellCaster
{
    public Cleric() : base()
    {
        int dexMod = GetAbilityMods()[1];
        int shieldArmor = 0;
        if (UserSetUsingShield() == true)
        {
            shieldArmor = 2;
        }
        KeyValuePair<string, List<int>> armorStats = ChooseArmorType();
        string armorName = armorStats.Key;
        int armorBase = armorStats.Value[0];
        int armorMax = armorStats.Value[1];
        SetArmorType(armorName);
        int ArmorMod = dexMod;
        if (dexMod > armorMax)
        {
            ArmorMod = armorMax;
        }
        SetArmorClass(armorBase + ArmorMod + shieldArmor);
    }
    public Cleric(string name, string characterClass, int maxHealth, List<int> abilityScores, string focus, bool usingShield, string armorType) 
    : base(name, characterClass, maxHealth, abilityScores, focus, usingShield)
    {
        int dexMod = GetAbilityMods()[1];
        int shieldArmor = 0;
        if(GetUsingShield() == true)
        {
            shieldArmor = 2;
        }
        KeyValuePair<string, List<int>> armorStats = ChooseArmorType(armorType);
        string armorName = armorStats.Key;
        int armorBase = armorStats.Value[0];
        int armorMax = armorStats.Value[1];
        SetArmorType(armorName);
        int ArmorMod = dexMod;
        if (dexMod > armorMax)
        {
            ArmorMod = armorMax;
        }
        SetArmorClass(armorBase + ArmorMod + shieldArmor);
    }
}