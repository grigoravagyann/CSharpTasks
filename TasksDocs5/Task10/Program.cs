/*
Task 10:  Find the Longest Word
Task: Write a program to find the longest word from the input words array:
    1) Write a method that returns the longest word from the input words array.
    2) Use params in method parameters.
    3) Call it with a user-provided words array.
*/

class MainClass
{
    static void Main(string[] args)
    {
        Console.Write("Enter words separated with spaces: ");
        string? input = Console.ReadLine();
        string[] wordsArray = input!.Split(' ');
        string longestWord = FindLongestWord(wordsArray);
        Console.WriteLine($"Longest word: {longestWord}"); 
    }
    static string FindLongestWord(params string[] words)
    {
        if (words.Length == 0)
            return "No words provided.";

        string longest = words[0];

        foreach (string word in words)
        {
            if (word.Length > longest.Length)
            {
                longest = word;
            }
        }

        return longest;
    }
}