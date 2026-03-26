public class Product
{
    private string _name;
    private string _productID;
    private int _pricePerUnit;
    private int _quantity;
    public Product(string name, string productID, int pricePerUnit, int quantity)
    {
        _name = name;
        _productID = productID;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public int TotalCost()
    {
        return _pricePerUnit * _quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetProductID()
    {
        return _productID;
    }

}