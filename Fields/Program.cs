using System;
class Program
{
    static void Main(string[] args)
    {
        var customer = new Customer(1);
        customer.Orders.Add(new Order());

        Console.WriteLine(customer.Orders.Count);

    }

}