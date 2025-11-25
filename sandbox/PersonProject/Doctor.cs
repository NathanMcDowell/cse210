class Doctor : Person
{
    private string _tools;

    public Doctor(string firstName, string lastName, string tools, int age, int weight)
    : base (firstName, lastName, age, weight)
    {
        _tools = tools;
    }

    public override string PersonInformation()
    {
        return $"{base.PersonInformation()}, Tools: {_tools}";
    }
    public override double GetSalary()
    {
        return 200000.99;
    }
}