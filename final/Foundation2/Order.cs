using System.Net.Http.Headers;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in _products)
        {
            totalPrice += product.GetTotalCost();
        }
        if (_customer.LivesInUSA())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }
        return totalPrice;
    }

    public void DisplayPackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.GetID()}: {product.GetName()}");
        }
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine($"{_customer.GetName()}\n{_customer.GetAddress()}");
    }
}