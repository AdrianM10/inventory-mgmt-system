using System;

namespace InventoryMgmtSystem;

public class Inventory
{
    private string _productName = "";
    private int _productQuantity = 0;

    private double _productPrice = 0;
    public string ProductName
    {
        get => _productName;
        set => _productName = value;
    }

    public int ProductQuantity
    {
        get => _productQuantity;
        set => _productQuantity = value;
    }

    public double ProductPrice
    {
        get => _productPrice;
        set => _productPrice = value;
    }

}
