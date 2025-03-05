/*
Task 2:  Swap Two Numbers
Task: Write a program to swap 2 numbers:
    1) Write a method to swap the values of two integers.
    2) Use ref in method parameters.
    3) Read 2 numbers from user input and validate the input values.
*/

class MainClass
{
    static void Main(string[] args)
    {
        Console.Write("Enter number for a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter number for b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Before swap: a = {a}, b = {b}");
        Swap(ref a, ref b);
        Console.WriteLine($"After swap: a = {a}, b = {b}");
    }

    static void Swap(ref int a, ref int b)
    {
        int tmp = a;
        a = b;
        b = tmp;
    }
}