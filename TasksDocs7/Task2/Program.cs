/*
Task 2:  Property with Validation and Default Value
Task: Create a Product class that contains:
    1) A Price property that: 
        1. Cannot be negative.
        2. If set to a negative value, defaults to 0.
    2) A Stock property that: 
        1. Cannot be negative.
        2. If set to a negative value, defaults to 10.
*/

class Product
{
    double _productPrice;
    double _productStock;
    public double Price
    {
        get
        {
            if (_productPrice < 0)
                _productPrice = 0;
            return _productPrice;
        }
        set => _productPrice = value;
    }
    public double Stock
    {
        get
        {
            if (_productStock < 0)
                _productStock = 10;
            return _productStock;
        }
        set => _productStock = value;
    }
}

class MainClass
{
    static void Main()
    {
        Product myProduct = new Product();
        myProduct.Price = -10;
        myProduct.Stock = -10;
        Console.WriteLine($"Price: {myProduct.Price}\nStock: {myProduct.Stock}");
    }
}