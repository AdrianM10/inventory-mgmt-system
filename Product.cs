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


    public void DisplayProduct()
    {
    
        Console.WriteLine("Please provide a product you would like to view: ");
        string product_name = Console.ReadLine();
        bool found = false;

        foreach (Product product in products)
        {
            if (product_name == product.Name)
            {
                Console.WriteLine($"Name: {product.Name}; Quantity: {product.Quantity}; Price: {product.Price}");
                found = true;
                break;
            }
        }
        if (!found)
        {
            Console.WriteLine($"{product_name} not found!");
        }
      
    }

    public void DisplayAllProducts()
    {
        Console.WriteLine("Retrieving all products...");
        foreach (Product product in products)
        {
            Console.WriteLine($"Name: {product.Name}; Quantity: {product.Quantity}; Price: {product.Price}");

        }
    }


    // Simulate updating product to inventory list

    // Simulate removing product from inventory list
    public void RemoveProduct(Product product)
    {
        products.Remove(product);
    }
}