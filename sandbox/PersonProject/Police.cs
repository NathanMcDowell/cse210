class Police : Person
{
    private string _weapons = "";
    
    public Police(string firstName, string lastName, string weapons, int age, int weight)
    : base (firstName, lastName, age, weight)
    {
        _weapons = weapons;
    }

    public override string PersonInformation()
    {
        return $"{base.PersonInformation()}, Weapons: {_weapons}";
    }
    public override double GetSalary()
    {
        return 50000.01;
    }
}