class Character
{
    private string _name;
    private string _class;
    private int _maxHealth;
    private int _currentHealth;
    private int _hitDieSize;
    private List<Item> _inventory;
    private List<int> _abilityScores;
    private List<int> _abilityMods;
    private string _armorType;
    private bool _usingShield;
    private int _armorClass;

    public Character()
    {
        Console.Write("Character name: ");
        _name = Console.ReadLine();
        Console.Write("Class:");
        _class = Console.ReadLine();
        Console.Write("Max Health: ");
        _maxHealth = int.Parse(Console.ReadLine());
        _currentHealth = _maxHealth;
    }
    public Character(string name, string characterClass, int maxHealth)
    {
        _name = name;
        _class = characterClass;
        _maxHealth = maxHealth;
        _currentHealth = maxHealth;
    }

    public string GetName(){return _name;}
    public string GetClass(){return _class;}
    public List<Item> GetInventory(){return _inventory;}
    public string GetGeneralStats()
    {
        return $"{_name}, {_class}, {_currentHealth}/{_maxHealth} HP";
    }
    public void AddItem(Item item)
    {
        
    }
    public void DealDamage(int damage)
    {
        _currentHealth -= damage;
        if (_currentHealth < 0)
        {
            _currentHealth = 0;
        }
    }
}