using System;

namespace Foundation2
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address();
            address1.SetStreetAddress("123 Main St");
            address1.SetCity("New York");
            address1.SetStateProvince("NY");
            address1.SetCountry("USA");

            Address address2 = new Address();
            address2.SetStreetAddress("50 Amada Col.");
            address2.SetCity("Zacatecas");
            address2.SetStateProvince("Zacatecas");
            address2.SetCountry("Mexico");

            Customer customer1 = new Customer();
            customer1.SetName("John Tyson");
            customer1.SetAddress(address1);

            Customer customer2 = new Customer();
            customer2.SetName("Adam Vilchez");
            customer2.SetAddress(address2);

            Product product1 = new Product();
            product1.SetName("Tesla Model X");
            product1.SetProductId(1);
            product1.SetPrice(60590.98m);
            product1.SetQuantity(2);

            Product product2 = new Product();
            product2.SetName("Burger King Crown");
            product2.SetProductId(2);
            product2.SetPrice(5.99m);
            product2.SetQuantity(5);

            Product product3 = new Product();
            product3.SetName("Tortilla Press");
            product3.SetProductId(3);
            product3.SetPrice(29.99m);
            product3.SetQuantity(4);

            Product product4 = new Product();
            product4.SetName("Corvette 2023");
            product4.SetProductId(4);
            product4.SetPrice(48520.97m);
            product4.SetQuantity(1);

            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product3);
            order2.AddProduct(product4);

            Console.WriteLine("Order 1 Packing Label:");
            Console.WriteLine(order1.GetPackingLabel());

            Console.WriteLine("Order 1 Shipping Label:");
            Console.WriteLine(order1.GetShippingLabel());

            decimal totalCost1 = order1.CalculateCost();
            Console.WriteLine($"\nOrder 1 Total Cost: ${totalCost1}\n");

            Console.WriteLine("Order 2 Packing Label:");
            Console.WriteLine(order2.GetPackingLabel());

            Console.WriteLine("Order 2 Shipping Label:");
            Console.WriteLine(order2.GetShippingLabel());

            decimal totalCost2 = order2.CalculateCost();
            Console.WriteLine($"\nOrder 2 Total Cost: ${totalCost2}");
        }
    }
}