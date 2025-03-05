/*
Task 5: Calculate Area and Perimeter
Task: Write a program for circle basic calculations:
    1) Write a method that calculates area and perimeter of a circle from radius.
    2) Use ref and out in method parameters.
    3) Call it with a user-provided radius value.
*/

class MainClass
{
    static void Main(string[] args)
    {
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        double area = 0;
        double perimeter;
        CalculateCircle(ref radius, out area, out perimeter);
        Console.WriteLine($"For a circle with radius {radius}:");
        Console.WriteLine($"Area = {area:F2}");
        Console.WriteLine($"Perimeter = {perimeter:F2}");
    }

    static void CalculateCircle(ref double radius, out double area, out double perimeter)
    {
        area = Math.PI * Math.Pow(radius, 2);        // Area = πr²
        perimeter = 2 * Math.PI * radius;            // Perimeter = 2πr
    }
}