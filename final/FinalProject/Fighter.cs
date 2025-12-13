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
        
    }
}