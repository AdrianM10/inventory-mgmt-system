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
                Console.WriteLine("4. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        // AddProduct();
                        Console.WriteLine("Simulating adding product");
                        break;
                    case "2":
                        // ViewProduct();
                        Console.WriteLine("Simulating returning product");
                        break;
                    case "3":
                        // ViewAllProducts();
                        Console.WriteLine("Simulate returning all products in inventory management system");
                        break;
                    case "4":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("You have selected an invalid option");
                        break;
                }
            }


            // string name = "";
            // double price = 0;
            // int quantity = 0;


            // Console.WriteLine("Please enter a product name: ");
            // name = Console.ReadLine();

            // Console.WriteLine($"Please enter a product price for {name}: ");
            // price = double.Parse(Console.ReadLine());

            // Console.WriteLine($"Please enter a quantity: ");
            // quantity = int.Parse(Console.ReadLine());

            // AddProduct(inventoryList, name, price, quantity);

            // Console.WriteLine($"Product Name is {name}");
            // Console.WriteLine($"The price for {name} is: $ {price}");
            // Console.WriteLine($"The current quantity for {name}'s is : {quantity}");
        }

        static void AddProduct(Inventory inventory, string name, double price, int quantity)
        {
            Product product = new Product
            {
                Name = name,
                Price = price,
                Quantity = quantity
            };
            inventory.AddProduct(product);
        }
    }
}

