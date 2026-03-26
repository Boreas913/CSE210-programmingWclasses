// Once you have created these classes, write a program that creates 
// at least two orders with a 2-3 products each. Call the methods to 
// get the packing label, the shipping label, and the total price of 
// the order, and display the results of these methods.

using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("5 Mill Race Rd", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Aurora", address1);
        Order order1 = new Order(customer1);
        Product product11 = new Product("Hairdryer", "4Df8903", 30, 2);
        Product product12 = new Product("Haircream", "JL29385", 15, 5);
        order1.AddProduct(product11);
        order1.AddProduct(product12);
        Console.WriteLine($"{order1.GetPackingLabel()}\n{order1.GetShippingLabel()}\n{order1.GetTotalCost()}");


        Address address2 = new Address("856 East Old Fort Rd", "South Weber", "UT", "USA");
        Customer customer2 = new Customer("Bob", address2);
        Order order2 = new Order(customer2);
        Product product21 = new Product("Waterbottle", "96357DH", 25, 2);
        Product product22 = new Product("Jumprope", "IP203876", 8, 3);
        order2.AddProduct(product21);
        order2.AddProduct(product22);
        Console.WriteLine($"{order2.GetPackingLabel()}\n{order2.GetShippingLabel()}\n{order2.GetTotalCost()}");
    }
}