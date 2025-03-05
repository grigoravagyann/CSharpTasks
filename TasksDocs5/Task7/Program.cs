/*
Task 7: Solve Quadratic Equation
Task: Write a program for solving Quadratic Equation:
    1) Write a method that calculates two roots using the quadratic formula: x = [-b ± √(b2 - 4ac)]/2a.
    2) Use ref and out in method parameters.
    3) Call it with a user-provided a, b and c values.
*/

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Solve quadratic equation: ax² + bx + c = 0");
        Console.Write("Enter coefficient a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter coefficient b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter coefficient c: ");
        double c = Convert.ToDouble(Console.ReadLine());
        SolveQuadratic(a, b, c);

    }

    static void SolveQuadratic(double a, double b, double c)
    {
        if (a == 0)
        {
            Console.WriteLine("This is not a quadratic equation (a cannot be 0).");
            return;
        }

        double discriminant = Math.Pow(b, 2) - 4*a*c;

        Console.WriteLine($"\nDiscriminant = {discriminant}");

        if (discriminant > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Two Real Solutions: x1 = {x1:F2}, x2 = {x2:F2}");
        }
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"One Real Solution: x = {x:F2}");
        }
        else
        {
            double realPart = -b / (2 * a);
            double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
            Console.WriteLine($"Two Complex Solutions: x1 = {realPart:F2} + {imaginaryPart:F2}i, x2 = {realPart:F2} - {imaginaryPart:F2}i");
        }
    }
}
