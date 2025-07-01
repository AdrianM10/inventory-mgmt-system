using System;
using System.Security.Cryptography.X509Certificates;

namespace InventoryMgmtSystem;

public class Product
{
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
}

public class Inventory
{
    public List<Product> products { get; set; } = new List<Product>();

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    
    public void ViewProduct(Product product)
    {
        Console.WriteLine(product);
    }

    public void DisplayAllProducts()
    {
        Console.WriteLine("------------------------------------");
        Console.WriteLine("Retrieving all products...");
        foreach (Product product in products)
        {
            Console.WriteLine($"Name: {product.Name}; Quantity: {product.Quantity}; Price: {product.Price}");

        }
        Console.WriteLine("------------------------------------");
    }


    // Simulate updating product to inventory list

    // Simulate removing product from inventory list
    public void RemoveProduct(Product product)
    {
        products.Remove(product);
    }
}