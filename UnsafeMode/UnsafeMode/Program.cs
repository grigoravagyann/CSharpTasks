/*
 Using stackalloc (System.Buffers), create an int array of 10 elements. 
 Use Console.ReadLine to input the elements of the array. Find the 
 index of the largest element by performing operations on the pointer.
 */
class Program
{ 
    unsafe public static void Main()
    {
        int* intArray = stackalloc int[10];
        Console.WriteLine("Enter 10 numbers: ");
        for (int i = 0; i < 10; ++i)
        {
            intArray[i] = Convert.ToInt32(Console.ReadLine());
        }
        int minIndex = 0;
        for (int i = 1; i < 10; ++i)
        {
            if (intArray[i] < intArray[minIndex])
                minIndex = i;
        }
        Console.WriteLine("The smallest number index is: " + minIndex);
    }
}