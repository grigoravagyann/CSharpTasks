/*
Task 1: Basic Calculator
Task: Write a program with methods for basic math operations:
    1) Add(int a, int b), Subtract(int a, int b), Multiply(int a, int b), Divide(int a, int b)
    2) Read 2 numbers from user input, read operation code and then display the result.
    3) Close the program if received X from the user.
    4) Use recursion to make the calculator run until it gets the X.
*/

using System;

static class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }
    public static int Subtract(int a, int b)
    {
        return a - b;
    }
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
    public static int Divide(int a, int b)
    {
        return a / b;
    }
    public static void CallCalculator()
    {
        Console.WriteLine("Calculator:\nEnter values and operator or X for exit: ");
        Console.Write("Enter value for number 1: ");
        string? _a = Console.ReadLine();
        if (_a == "X")
            Environment.Exit(0);
        int a = Convert.ToInt32(_a);
        Console.Write("Enter value for number 2: ");
        string? _b = Console.ReadLine();
        if (_b == "X")
            Environment.Exit(0);
        int b = Convert.ToInt32(_b);
        Label:
        Console.Write("Enter operator for numbers: ");
        string? userOperator = Console.ReadLine();
        if(userOperator != "+" && userOperator != "-" && userOperator != "*" && userOperator != "/" && userOperator != "X")
        {
            Console.WriteLine("Invalid operator! Try again.");
            goto Label;
        }
        int retVal = 0;
        switch(userOperator)
        {
            case "+":
                retVal = Add(a, b);
                break;
            case "-":
                retVal = Subtract(a, b);
                break;
            case "*":
                retVal = Multiply(a, b);
                break;
            case "/":
                retVal = Divide(a, b);
                break;
            case "X":
                Environment.Exit(0);
                break;
        }

        Console.WriteLine($"Return value: {retVal}\n");
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        while(true)
        {
            Calculator.CallCalculator();
        }
    }
}