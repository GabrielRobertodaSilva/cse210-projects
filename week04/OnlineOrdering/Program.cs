using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: Customer in the USA ($5 shipping, 3 products)
        Address address1 = new Address("742 Evergreen Terrace", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Carter", address1);

        List<Product> products1 = new List<Product>
        {
            new Product("Hydraulic Pressure Gauge", "PRD-101", 24.50, 2),
            new Product("Vitron O-Ring Kit", "PRD-204", 12.00, 3),
            new Product("Thread Sealant Tape", "PRD-309", 4.25, 2)
        };

        Order order1 = new Order(products1, customer1);
        DisplayOrder(order1, 1);

        // Order 2: Customer outside the USA ($35 shipping, 2 products)
        Address address2 = new Address("Rua XV de Novembro, 450", "Navegantes", "SC", "Brazil");
        Customer customer2 = new Customer("Gabriel Silva", address2);

        List<Product> products2 = new List<Product>
        {
            new Product("Digital Caliper 150mm", "PRD-410", 38.00, 1),
            new Product("Heavy-Duty Shop Gloves", "PRD-512", 14.50, 2)
        };

        Order order2 = new Order(products2, customer2);
        DisplayOrder(order2, 2);
    }

    static void DisplayOrder(Order order, int orderNumber)
    {
        Console.WriteLine($"================ ORDER #{orderNumber} ================");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order.CalculateTotalCost():F2}");
        Console.WriteLine("==========================================\n");
    }
}