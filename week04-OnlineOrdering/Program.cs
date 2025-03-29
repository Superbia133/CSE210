using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA)
        Address address1 = new Address("123 Elm St", "Ventura", "CA", "USA");
        Customer customer1 = new Customer("Edward Gamer", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Keyboard", "KB001", 50.00, 1));
        order1.AddProduct(new Product("Mouse", "MS002", 25.00, 2));

        // Order 2 (International)
        Address address2 = new Address("456 Maple Rd", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Alice Coder", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Laptop Stand", "LS003", 40.00, 1));
        order2.AddProduct(new Product("USB Hub", "UH004", 20.00, 3));

        // Display Order 1
        Console.WriteLine("=== Order 1 ===");
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine("\nPacking Label:\n" + order1.GetPackingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        // Display Order 2
        Console.WriteLine("=== Order 2 ===");
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine("\nPacking Label:\n" + order2.GetPackingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}
