using System;

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

    public void ModifyProduct()
    {
        Console.WriteLine("Please enter a product name you would like to update: ");
        string product_name = Console.ReadLine();
        bool found = false;

        for (int i = 0; i < products.Count; i++)
        {
            if (products[i].Name == product_name)
            {
                found = true;
                Console.WriteLine($"Please select a property to update for {product_name}:");
                Console.WriteLine("1. Update Quantity");
                Console.WriteLine("2. Update Price");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":

                        Console.WriteLine("Please enter a new quantity:");
                        int quantity = int.Parse(Console.ReadLine());
                        products[i].Quantity = quantity;
                        Console.WriteLine($"Updating quantity for {product_name}.");
                        break;
                    case "2":
                        Console.WriteLine("Please enter a new price:");
                        double price = double.Parse(Console.ReadLine());
                        products[i].Price = price;
                        Console.WriteLine($"Updating price for {product_name}");
                        break;
                }
                break;
            }

        }
        if (!found)
        {
            Console.WriteLine($"{product_name} not found!");
        }
    }

    public void DisplayProduct()
    {

        Console.WriteLine("Please enter a product name you would like to view: ");
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
        if (products.Count == 0)
        {
            Console.WriteLine("No products in inventory");
        }
        else
        {
            foreach (Product product in products)
            {
                Console.WriteLine($"Name: {product.Name}; Quantity: {product.Quantity}; Price: {product.Price}");

            }
        }

    }

    public void DeleteProduct()
    {
        Console.WriteLine("Please enter a product name to remove");
        string product_name = Console.ReadLine();
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