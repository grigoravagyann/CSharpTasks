/*
Task: "Product Inventory Manager"
    Use ։ 2 classes "Product" and "Inventory Manager", with overloaded, params, ref, out, and extension methods
*/

public class Product
{
    string _productName;
    double _productPrice;
    int _productQuantity;

    public string Name
    {
        get { return _productName; }
    }
    public double Price
    {
        get { return _productPrice; }
    }
    public int Quantity
    {
        get { return _productQuantity; }
    }
    public Product(string Name, double Price, int Quantity)
    {
        _productName = Name;
        _productPrice = Price;
        _productQuantity = Quantity;
    }
    public double TotalPrice()
    {
        return Price*Quantity;
    }
}

public class InventoryManager
{
    public  List<Product> productStock = new List<Product>();
    
    public void DisplayProducts()
    {
        for(int i=0; i<productStock.Count; ++i)
        {
            Console.WriteLine($"Product {i+1}:\nProductName: {productStock[i].Name}, ProductPrice: {productStock[i].Price}, Quantity: {productStock[i].Quantity}");
        }
    }
}

public static class InventoryExtensions
{
    public static void AddProduct(this InventoryManager classStock, params Product[] products)
    {
        foreach ( var product in products)
        {
            classStock.productStock.Add(product);
        }
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        Product[] product = new Product[2];
        product[0] = new Product("b",1,1);
        product[1] = new Product("a",1,1);
        InventoryManager productsStock = new InventoryManager();
        productsStock.AddProduct(product);
        productsStock.DisplayProducts();
    }
}
