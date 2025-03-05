/*
Task 6: Sum of Any Numbers
Task: Write a program for numbers sum calculation:
    1) Write a method that calculates the sum of the numbers in an array.
    2) Use params in method parameters.
    3) Read numbers from user input.
*/

class MainClass
{
    static void Main(string[] args)
    {
        int[] array = new int[10];
        for (int i = 0; i < array.Length; ++i)
        {
            array[i] = i+1;
        }
        int arraySum = ArraySum(array);
        Console.WriteLine($"Sum of array: {arraySum}");
    }

    static int ArraySum(params int[] array)
    {
        int sum = 0;
        for (int i = 0;i < array.Length; ++i)
        {
            sum += array[i];
        }
        return sum;
    }
}