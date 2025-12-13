class Character
{
    private string _name;
    private string _class;
    private int _maxHealth;
    private int _currentHealth;
    // private int _hitDieSize;
    private List<Item> _inventory = [];
    private List<int> _abilityScores = [];
    private List<int> _abilityMods = [];
    private string _armorType;
    private bool _usingShield =  false;
    private int _armorClass;

    public Character()
    {
        Console.Write("Character name: ");
        _name = Console.ReadLine();
        Console.Write("Class: ");
        _class = Console.ReadLine();
        Console.Write("Max Health: ");
        _maxHealth = int.Parse(Console.ReadLine());
        _currentHealth = _maxHealth;
        Console.WriteLine("Input your ability scores in this format:");
        Console.WriteLine("Str, Dex, Con, Int, Wis, Cha");
        string abilityScoreString = Console.ReadLine();
        List<string> abilityScoreStringList = abilityScoreString.Split(", ").ToList();
        foreach(string score in abilityScoreStringList)
        {
            _abilityScores.Add(int.Parse(score));
        }
        foreach(int score in _abilityScores)
        {
            int mod = (score - 10) / 2;
            _abilityMods.Add(mod);
        }
        
    }
    public Character(string name, string characterClass, int maxHealth, List<int> abilityScores)
    {
        _name = name;
        _class = characterClass;
        _maxHealth = maxHealth;
        _currentHealth = maxHealth;
        _abilityScores = abilityScores;
        foreach(int score in _abilityScores)
        {
            int mod = (score - 10) / 2;
            _abilityMods.Add(mod);
        }
        
    }

    public string GetName(){return _name;}
    public string GetClass(){return _class;}
    public List<Item> GetInventory(){return _inventory;}
    public List<int> GetAbilityScores(){return _abilityScores;}
    public List<int> GetAbilityMods(){return _abilityMods;}
    public bool GetUsingShield(){return _usingShield;}
    public int GetArmorClass(){return _armorClass;}
    public string GetArmorType(){return _armorType;}

    public void SetUsingShield(bool value)
    {
        _usingShield = value;
    }
    public bool UserSetUsingShield()
    {
        Console.WriteLine("Are you using a shield? (y/n)");
        string usingShield = Console.ReadLine();
        if (usingShield == "y")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void SetArmorClass(int ac){_armorClass = ac;}
    public void SetArmorType(string armorType){_armorType = armorType;}


    public virtual string GetGeneralStats()
    {
        return $"{_name}, {_class}, {_currentHealth}/{_maxHealth} HP";
    }
    public void AddItem(Item item)
    {
        _inventory.Add(item);
    }
    public void DealDamage(int damage)
    {
        _currentHealth -= damage;
        if (_currentHealth < 0)
        {
            _currentHealth = 0;
        }
    }
    public KeyValuePair<string, List<int>> ChooseArmorType()
    {

        Dictionary<string, List<int>> armorList = new()
        {
            ["Padded"] = [11, 10],
            ["Leather"] = [11, 10],
            ["Studded Leather"] = [12, 10],
            ["Hide"] = [12, 2],
            ["Chain Shirt"] = [13, 2],
            ["Scale mail"] = [14, 2],
            ["Breastplate"] = [14, 2],
            ["Half plate"] = [15, 2],
            ["Ring mail"] = [14, 0],
            ["Chain mail"] = [16, 0],
            ["Splint"] = [17, 0],
            ["Plate"] = [18, 0]
        };
        int count = 1;
        Console.WriteLine();
        foreach(KeyValuePair<string, List<int>> armor in armorList)
        {
            Console.WriteLine($"{count}. {armor.Key}");
            count++;
        }
        Console.WriteLine("Choose a number: ");
        int armorIndex = int.Parse(Console.ReadLine()) - 1;
        int currentIndex = 0;
        KeyValuePair<string, List<int>> selectedArmor = new("No armor", [10, 10]);
        foreach(KeyValuePair<string, List<int>> armor in armorList)
        {
            if (currentIndex == armorIndex)
            {
                selectedArmor = armor;
                Console.WriteLine(armor.Key);
                break;
            }
            currentIndex++;
        }
        return selectedArmor;
        
    }
    public KeyValuePair<string, List<int>> ChooseArmorType(string armorName)
    {

        Dictionary<string, List<int>> armorList = new()
        {
            ["Padded"] = [11, 10],
            ["Leather"] = [11, 10],
            ["Studded Leather"] = [12, 10],
            ["Hide"] = [12, 2],
            ["Chain Shirt"] = [13, 2],
            ["Scale mail"] = [14, 2],
            ["Breastplate"] = [14, 2],
            ["Half plate"] = [15, 2],
            ["Ring mail"] = [14, 0],
            ["Chain mail"] = [16, 0],
            ["Splint"] = [17, 0],
            ["Plate"] = [18, 0]
        };
        KeyValuePair<string, List<int>> selectedArmor = new("No armor", [10, 10]);

        foreach(KeyValuePair<string, List<int>> armor in armorList)
        {
            if(armor.Key == armorName)
            {
                selectedArmor = armor;
            }
        }

        return selectedArmor;
    }
}