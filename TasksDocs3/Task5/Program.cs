/*
Task 5: Online Shopping Cart
Task: Create a Product class with:
    1) Name, Price, and Quantity.
    2) A method TotalPrice() that returns Price * Quantity.
    3) In Main(), allow the user to add multiple products to a shopping cart and calculate the total cost.
    4) If more than 5 items are purchased, apply a 10% discount.
*/


using System;

class Product
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

class MainClass
{
    static void Main(string[] args)
    {
        List<Product> shoppingCart = new List<Product>();
        double totalCost = 0;

        while (true)
        {
            Console.Write("Enter product name or type 'Done' to finish: ");
            string? productName = Console.ReadLine();
            if (productName!.ToLower() == "done")
                break;
            Console.Write("Enter product price: ");
            double productPrice = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter product quantity: ");
            int productQuantity = Convert.ToInt32(Console.ReadLine());

            Product product = new Product(productName, productPrice, productQuantity);
            shoppingCart.Add(product);
            Console.WriteLine($"Added {productQuantity} x {productName} to the cart.");
        }
    
        foreach (Product i in shoppingCart)
        {
        totalCost += i.TotalPrice();
        }

            if (shoppingCart.Count > 5)
        {
            totalCost *=  0.9;
            Console.WriteLine("A 10% discount has been applied!");
        }

        Console.WriteLine($"Total cost of the shopping cart: {totalCost:F2} $");
    }
}