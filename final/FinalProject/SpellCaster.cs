class SpellCaster : Character
{
    private string _focus;
    public SpellCaster() : base()
    {
        Console.Write("Spellcasting Focus: ");
        _focus = Console.ReadLine();
    }
}