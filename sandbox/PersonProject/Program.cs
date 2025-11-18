class Program
{
    
    static void Main(string[] args)
    {
        Person person = new("John", "Smith", 99, 220);
        Console.WriteLine(person.PersonInformation());

        Police police = new Police("Taser and Jujitsu","Barbara", "Gordon", 28, 150);
        Console.WriteLine(police.PoliceInformation());
    }
}