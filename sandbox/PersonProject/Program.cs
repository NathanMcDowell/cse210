class Program
{
    public static void DisplayPersonInformation(Person person)
    {
        Console.Write(person.PersonInformation());
        Console.WriteLine($", Salary: ${person.GetSalary()}");
    }
    static void Main(string[] args)
    {
        // Person person = new("John", "Smith", 99, 220);
        // Console.WriteLine(person.PersonInformation());

        Police police = new Police("Barbara", "Gordon", "Taser and Jujitsu", 28, 150);
        Console.WriteLine(police.PersonInformation());

        Doctor doctor = new("Plague", "Doctor", "Leeches", 50, 140);
        Console.WriteLine(doctor.PersonInformation());

        Surgeon surgeon = new("Doctor", "John", "Detective", "Bandages", 30, 162);
        Console.WriteLine(surgeon.PersonInformation());

        Console.WriteLine("\n\n\n\n\n\n");

        List<Person> myPeople = new();
        // myPeople.Add(person);
        myPeople.Add(police);
        myPeople.Add(doctor);
        myPeople.Add(surgeon);

        foreach(Person p in myPeople)
        {
            DisplayPersonInformation(p);
        }
    }
}