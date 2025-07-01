using System.Runtime.CompilerServices;
using InventoryMgmtSystem;

namespace InventoryMgmtSystem
{
    class Program
    {
        static Inventory inventoryList = new();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Inventory Management System");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View Product");
                Console.WriteLine("3. View All Products");
                Console.WriteLine("4. Update Product");
                Console.WriteLine("5. Remove Product");
                Console.WriteLine("6. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddProduct(inventoryList);

                        break;
                    case "2":
                        ViewProduct(inventoryList);

                        break;
                    case "3":
                        ViewAllProducts(inventoryList);

                        break;
                    case "4":
                        UpdateProduct(inventoryList);
                        break;
                    case "5":
                        RemoveProduct(inventoryList);
                        break;
                    case "6":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("You have selected an invalid option");
                        break;
                }
            }



        }

        static void AddProduct(Inventory inventoryList)
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

            Console.WriteLine($"Product Name is {name}");
            Console.WriteLine($"The price for {name} is: $ {price}");
            Console.WriteLine($"The current quantity for {name}'s is : {quantity}");

            Product product = new Product
            {
                Name = name,
                Price = price,
                Quantity = quantity
            };
            inventoryList.AddProduct(product);
        }

        static void UpdateProduct(Inventory inventoryList)
        {
            Console.WriteLine("Enter product name to update... Simulating update");
        }

        static void ViewProduct(Inventory inventoryList)
        {
            Console.WriteLine("Please provide a product you would like to view: ");
            string product_name = Console.ReadLine();

            foreach (Product product in inventoryList.products)
            {
                if (product_name == product.Name)
                {
                    Console.WriteLine($"Name: {product.Name}; Quantity: {product.Quantity}; Price: {product.Price}");
                }
                else
                {
                    Console.WriteLine($"{product_name} not found!");
                }
            }

        }

        static void ViewAllProducts(Inventory inventoryList)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Retrieving all products...");
            foreach (Product product in inventoryList.products)
            {
                Console.WriteLine($"Name: {product.Name}; Quantity: {product.Quantity}; Price: {product.Price}");

            }
            Console.WriteLine("------------------------------------");

        }

        static void RemoveProduct(Inventory inventoryList)
        {
            Console.WriteLine("Please enter a product name to remove");
            String product_name = Console.ReadLine();
            bool found = false;

            for (int i = 0; i < inventoryList.products.Count; i++)
            {
                if (inventoryList.products[i].Name == product_name)
                {
                    inventoryList.RemoveProduct(inventoryList.products[i]);
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
}

