class Program
{
    static void Main()
    {
        // Console.WriteLine("Bonjour tout le monde");
        Planet mercury = new Planet();
        mercury._name = "Mercury";
        mercury._diameter = 3031.9;

        Planet venus = new Planet();
        venus._name = "Venus";
        venus._diameter = 7520.8;

        Planet earth = new Planet();
        earth._name = "Earth";
        earth._diameter = 7926.2;

        SolarSystem solarSystem = new SolarSystem();
        solarSystem._solarSystem.Add(mercury);
        solarSystem._solarSystem.Add(venus);
        solarSystem._solarSystem.Add(earth);

        solarSystem.DisplaySolarSystem();

    }
}