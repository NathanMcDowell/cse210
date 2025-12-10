class Item
{
    private string _name;
    private int _quantity;

    public Item(string name, int quantity)
    {
        _name = name;
        _quantity = quantity;
    }
    public void ModifyQuantity(int number)
    {
        _quantity += number;
    }
    public string GetItem()
    {
        return $"{_quantity} {_name}";
    }
}