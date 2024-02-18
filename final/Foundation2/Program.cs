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

        Address address2 = new Address("1357 Norte", "San Miguel", "PUE", "MEX");
        Customer customer2 = new Customer("Maria Jose", address2);
        Order order2 = new Order(customer2);
        Product headphones = new Product("Headphones", "MNB456", 100, 2);
        Product charger = new Product("Charger", "LKJ283", 20, 2);
        order2.AddProduct(headphones);
        order2.AddProduct(charger);
        orders.Add(order2);

        foreach (Order order in orders)
        {
            Console.WriteLine("-----------------------------------");
            order.DisplayPackingLabel();
            Console.WriteLine("-----------------------------------");
            order.DisplayShippingLabel();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Total: ${order.GetTotalPrice()}\n");
            Console.WriteLine("-----------------------------------");
        }
    }
}