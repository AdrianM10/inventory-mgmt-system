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
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Inventory Management System, please select an option from the below: \n");
                Console.WriteLine("1. Add Product");
                Console.WriteLine("2. View Product");
                Console.WriteLine("3. View All Products");
                Console.WriteLine("4. Update Product");
                Console.WriteLine("5. Remove Product");
                Console.WriteLine("6. Exit \n");

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
            inventoryList.InsertProduct();
        }

        static void UpdateProduct(Inventory inventoryList)
        {
            inventoryList.ModifyProduct();
        }

        static void ViewProduct(Inventory inventoryList)
        {
            inventoryList.DisplayProduct();
        }

        static void ViewAllProducts(Inventory inventoryList)
        {
            inventoryList.DisplayAllProducts();
        }

        static void RemoveProduct(Inventory inventoryList)
        {
            inventoryList.DeleteProduct();
        }

    }
}

