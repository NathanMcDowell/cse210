class Fighter : Martial
{
    public Fighter() : base()
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
    public Fighter(string name, string characterClass, int maxHealth, List<int> abilityScores, string weapon, bool usingShield, string armorType) 
    : base(name, characterClass, maxHealth, abilityScores, weapon, usingShield)
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