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

    public void InsertProduct()
    {
        string name = "";
        double price = 0;
        int quantity = 0;


        Console.WriteLine("Please enter a product name: ");
        name = Console.ReadLine();

        Console.WriteLine($"Please enter a product price for {name}: ");
        price = double.Parse(Console.ReadLine());

        Console.WriteLine($"Please enter a quantity: ");
        quantity = int.Parse(Console.ReadLine());

        Console.WriteLine($"Adding {quantity} {name}(s) at $ {price} each to inventory");

        Product product = new Product
        {
            Name = name,
            Price = price,
            Quantity = quantity
        };
        products.Add(product);
    }

    // Add method to Update Product
    public void ModifyProduct()
    {
        Console.WriteLine("Simulate updating a product");
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
        Console.WriteLine("Retrieving all products... \n");
        foreach (Product product in products)
        {
            Console.WriteLine($"Name: {product.Name}; Quantity: {product.Quantity}; Price: {product.Price}");

        }
    }

    public void DeleteProduct()
    {
        Console.WriteLine("Please enter a product name to remove");
        String product_name = Console.ReadLine();
        bool found = false;

        for (int i = 0; i < products.Count; i++)
        {
            if (products[i].Name == product_name)
            {
                products.Remove(products[i]);
                Console.WriteLine($"{product_name} has been removed");
                found = true;
                break;
            }
        }

        if (!found)
        {
            Console.WriteLine($"{product_name} not found!");
        }
    }
}