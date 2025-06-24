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

    // Simulate add product to inventory list
    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    // Simulate viewing all products
   


    // Simulate updating product to inventory list

    // Simulate removing product from inventory list
}