class Martial : Character
{
    private string _weapon;
    public Martial() : base()
    {
        Console.Write("Weapon: ");
        _weapon = Console.ReadLine();
    }
}