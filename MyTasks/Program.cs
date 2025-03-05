using System;

// class indexRemove
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Input string: ");
//         string? data = Console.ReadLine();
//         Console.Write("Input the character's index you want to remove from string: ");
//         int index = Convert.ToInt32(Console.ReadLine());
//         data = data.Remove(index,1);
//         Console.WriteLine("Result: {0}", data);
//     }
// }

// class swapFirstLast
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Input your string: ");
//         string? inputString = Console.ReadLine();
//         inputString = inputString.Length > 1 ? inputString.Substring(inputString.Length - 1) + inputString.Substring(1, inputString.Length -2) + inputString.Substring(0,1) : inputString;
//         Console.WriteLine($"First and last character's swapped string: {inputString}");
//     }
// }

// class longestWord
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Input your string: ");
//         string? input = Console.ReadLine();
//         string[] words = input.Split(' ');
//         string longestWord = words[0];

//         foreach(string word in words)
//         {
//             if(word.Length > longestWord.Length)
//             {
//                 longestWord = word;
//             }
//         }
//         Console.WriteLine($"Longest word: {longestWord}");
//     }
// }

// class primesSum
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Enter for what number to sum primes: ");
//         int number = Convert.ToInt32(Console.ReadLine());
//         int sum = 0;
//         int checkNumber = 2;

//         while(checkNumber <= number)
//         {
//             if(isPrime(checkNumber))
//             {
//                 sum += checkNumber;
//             }
//             ++checkNumber;
//         }

//         Console.WriteLine(sum);
//     }

//     public static bool isPrime(int checkNumber)
//     {
//         if( checkNumber == 1) return false;
//         if(checkNumber == 2) return true;

//         for(int i = 2; i <= checkNumber/2; ++i)
//         {
//             if(checkNumber % i == 0) return false;
//         }
//         return true;
//     }
// }

// class arrayLeftRotate
// {
//     static void Main(string[] args)
//     {
//         int[] array = {1, 2, 8, 5, 6};
//         for(int i = 0; i < array.Length-1; ++i)
//         {
//             int tmp = array[i];
//             array[i] = array[i+1];
//             array[i+1] = tmp;
//         }
//         Console.WriteLine($"Rotated array: {array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}");
//     }
// }

// class cumulativeSum
// {
//     static void Main(string[] args)
//     {
//         int[] originalArray = { 1, 2, 3, 4, 5};
//         int[] cumulativeArray = new int[5];
//         cumulativeArray[0] = originalArray[0];
//         for (int i = 1; i < 5; ++i)
//         {
//             cumulativeArray[i] = originalArray[i] + cumulativeArray[i - 1];
//         }
//         for(int i = 0; i < 5; ++i)
//         {
//             Console.Write($"{cumulativeArray[i]} ");
//         }
//     }
// }

// class mixedObjectInts
// {
//     static void Main(string[] args)
//     {
//         object[] mixedObject = new object[6];
//         mixedObject[0] = 25;
//         mixedObject[1] = "Anna";
//         mixedObject[2] = false;
//         mixedObject[3] = DateTime.Now;
//         mixedObject[4] = -112;
//         mixedObject[5] = -34.67;
    
//         for (int i = 0; i < mixedObject.Length; i++)
//             {
//                 Console.Write(mixedObject[i] + " ");
//             }
//         Console.Write("\n");

//         int[] objectInts = mixedObject.OfType<int>().ToArray();
    
//         for(int i = 0; i < objectInts.Length; i++)
//         {
//             Console.Write(objectInts[i] + " ");
//         }
    
//     }
// }