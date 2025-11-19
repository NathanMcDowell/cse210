class Program
{
    
    static void Main(string[] args)
    {
        Person person = new("John", "Smith", 99, 220);
        Console.WriteLine(person.PersonInformation());

        Police police = new Police("Taser and Jujitsu","Barbara", "Gordon", 28, 150);
        Console.WriteLine(police.PoliceInformation());

        Doctor doctor = new("Leeches", "Plague", "Doctor", 50, 140);
        Console.WriteLine(doctor.DoctorInformation());
        // doctor.SetAge(51);
        // doctor.SetWeight(150);
        // Console.WriteLine(doctor.DoctorInformation());

        Surgeon surgeon = new("Doctor", "Bandages", "John", "Detective", 30, 162);
        Console.WriteLine(surgeon.SurgeonInformation());
    }
}