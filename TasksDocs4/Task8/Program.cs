/*
Task 8: E-Commerce Product System
Task: Create a class Product with:
    1) Fields name, price, and stockQuantity.
    2) Add a constructor that uses this to differentiate between parameters and fields.
    3) In Main(), create a product and display its details.
*/

class Product
{
    string? _productName;
    string? _productPrice;
    public string Name
    {
        get => _productName!;
    }
    public string Price
    {
        get => _productPrice!;
    }
    public Product(string _productName, string _productPrice)
    {
        this._productName = _productName;
        this._productPrice = _productPrice;
    }
    public static Product Create()
    {
        Console.Write("Enter product name: ");
        string? productName = Console.ReadLine();
        Console.Write("Enter product price: ");
        string? productPrice = Console.ReadLine();
        Product newProduct = new Product(productName!, productPrice!);

        return newProduct;
    }
    public void DisplayDetails()
    {
        Console.WriteLine($"Product: {_productName}, Price: {_productPrice}");
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        Product newProduct = Product.Create();
        newProduct.DisplayDetails();
    }
}