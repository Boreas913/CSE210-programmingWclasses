public class Order
{
    List<Product> _products;
    private Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public int GetSubtotal()
    {
        int total = 0;
        foreach (Product product in _products)
        {
            total += product.TotalCost();
        }
        return total;
    }
    public int GetShippingCost()
    {
        if (_customer.LivesInUSA())
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }
    public int GetTotalCost()
    {
        return GetSubtotal() + GetShippingCost();
    }
    public string GetShippingLabel()
    {
        return $"{_customer.GetName()}\n {_customer.GetAddressString()}";
    }

    public string  GetPackingLabel(){
        string packingLabel = "Contents: \n";
        foreach (Product p in _products)
        {
            packingLabel += $"{p.GetName()} - {p.GetProductID()}\n";
        }
        return packingLabel;
    }
}