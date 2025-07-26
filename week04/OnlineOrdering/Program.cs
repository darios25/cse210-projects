using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Kaysville", "Utah", "USA");
        Customer customer1 = new Customer("Amy Smith", address1);

        Product product1 = new Product("Laptop", "LT001", 3.50, 4);
        Product product2 = new Product("Cellphone", "CP002", 1.20, 10);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        Address address2 = new Address("Via Roma 51", "Palermo", "Sicily", "Italy");
        Customer customer2 = new Customer("Alessandro Del Piero", address2);

        Product product3 = new Product("Snickers", "SN003", 7.80, 2);
        Product product4 = new Product("T-shirt", "TS004", 5.00, 3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }


}