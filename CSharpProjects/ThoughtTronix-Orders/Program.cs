using homework_1_albertspencer.Models;
using System;
using System.Collections.Generic;


Product mindSync = new Product("MindSync", "Neural Implant Device", 1995.99M);
Product seraphine = new Product("Seraphine", "AI Assistant", 200.00M);
Product soulSear = new Product("SoulSear", "Military Grade Death Ray", 4300000000.00M);
Product phantomClaw = new Product("PhantomClaw", "High Quality Gaming Mouse", 99.95M);


Order order1 = new Order(1, "US Government");
order1.Products.Add(soulSear);
order1.Products.Add(mindSync);
order1.Products.Add(seraphine);

Order order2 = new Order(2, "North Korea");
order2.Products.Add(mindSync);
order2.Products.Add(soulSear);
order2.Products.Add(phantomClaw);

Order order3 = new Order(3, "Kareem Dana");
order3.Products.Add(seraphine);
order3.Products.Add(phantomClaw);

List<Order> orders = new List<Order> { order1, order2, order3 };


foreach (var order in orders)
{
    Console.WriteLine(order); 
    foreach (var product in order.Products) 
    {
        Console.WriteLine($"\t{product}");
    }
    Console.WriteLine($"Order Total: ${order.GetTotal():N2}");
    Console.WriteLine();
}
