using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("20422 Cohasset St","Winnetka","CA","USA");
        Customer customer1 = new Customer("Jonathan Acosta", address1);

         Address address2 = new Address("20112 Mason Ave","Los Angeles","CA","USA");
        Customer customer2 = new Customer("Melissa Vasquez", address2);

        Product product1 = new Product("Ball",1,15.00m, 2);
        Product product2 = new Product("Jersey",2,40.00m, 1);
        Product product3 = new Product("Video Games",3,70.00m, 3);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        Console.WriteLine("Order 1 - Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Order 1 - Shipping Label:" + order1.GetShippingLabel());
        Console.WriteLine("Order 1 - Total Price: $" + order1.GetTotalCost());

        Console.WriteLine("\n -----------------\n");

        Console.WriteLine("Order 2 - Packing Label: \n" + order2.GetPackingLabel());
        Console.WriteLine("Order 2 - Shipping Label:" + order2.GetShippingLabel());
        Console.WriteLine("Order 2 - Total Price: $" + order2.GetTotalCost());
    }
}