/*
Task 8: Fibonacci Sequence
Task: Write a program that returns n-th number from Fibonacci Sequence:
    1) Write a recursive method that returns the n-th number in Fibonacci Sequence.
    2) Call it with a user-provided n.
*/

class MainClass
{
    static void Main(string[] args)
    {
        Console.Write("Enter index for Fibonacci: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int res = FibonacciN(n);
        Console.WriteLine($"Result: {res}");
    }
    static int FibonacciN(int n)
    {
        if (n == 0)
            return 0;
        if (n == 1)
            return 1;
        return FibonacciN(n-1) + FibonacciN(n-2);
    }
}