/*
Task 3:  Find the maximum from the numbers
Task: Write a program to find max from input numbers array:
    1) Write a method to find the maximum value from an array of input numbers.
    2) Use ref and params in method parameters.
    3) Read numbers from user input.
*/

class MainClass
{
    static void Main(string[] args)
    {
        int arrayMax = int.MinValue;
        int[] array = new int[10];
        for (int i = 0; i < array.Length; ++i)
        {
            Console.Write($"Enter number {i+1} for array: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        FindMaximum(ref arrayMax, array);
        Console.WriteLine($"Maximum number of array: {arrayMax}");
    }

    static void FindMaximum(ref int max, params int[] array)
    {
        for (int i = 0; i < array.Length; ++i)
        {   
            if(array[i] > max)
            {
                max = array[i];
            }
        }
    }
}