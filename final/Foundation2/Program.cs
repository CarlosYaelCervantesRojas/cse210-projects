using System;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Address address1 = new Address("1357 Blane Street", "New Brunswick", "NJ", "USA");
        Customer customer1 = new Customer("Brian J. Wacker", address1);
        Order order1 = new Order(customer1);
        Product phone = new Product("Phone", "ADD123", 250, 1);
        Product usb = new Product("USB Memory", "ZXC456", 32, 5);
        order1.AddProduct(phone);
        order1.AddProduct(usb);
        orders.Add(order1);

        foreach (Order order in orders)
        {
            order.DisplayPackingLabel();
            Console.WriteLine("-----------------------------------");
            order.DisplayShippingLabel();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Total: ${order.GetTotalPrice()}\n");
        }
    }
}