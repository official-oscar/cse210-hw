using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P1001", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "P1002", 25.50, 2));
        order1.AddProduct(new Product("Keyboard", "P1003", 75.00, 1));

        Address address2 = new Address("456 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Maria Garcia", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "P2001", 199.99, 1));
        order2.AddProduct(new Product("Webcam", "P2002", 89.99, 1));
        order2.AddProduct(new Product("Charger", "P2003", 49.99, 1));

        Console.WriteLine("===== ORDER 1 =====");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}");
        Console.WriteLine();

        Console.WriteLine("===== ORDER 2 =====");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
    }
}