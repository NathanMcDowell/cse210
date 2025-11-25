class Surgeon : Doctor
{
    private string _title;

    public Surgeon(string title, string firstName, string lastName, string tools, int age, int weight)
    : base (firstName, lastName, tools, age, weight)
    {
        _title = title;
    }
    
    public override string PersonInformation()
    {
        return $"{_title} {base.PersonInformation()}";
    }
    public override double GetSalary()
    {
        return base.GetSalary() + 100000;
    }
}