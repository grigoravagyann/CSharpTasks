/*
The task is to implement a custom string-like class, MyString, in C#. 
Functional Requirements:
    1) Constructors:
        Implement multiple constructors for initializing MyString objects.
        Constructor with no parameters (default constructor).
        Constructor accepting a single string.
        Constructor accepting a single char array.
        Constructor that accepts a string array.
    2) Comparison:
        Implement Compare methods to compare the current MyString object with another string or MyString object.
        Overload the == and != operators for equality and inequality comparison.
    3) Equals:
        Implement Equals(Object? other).
        Implement a static version of Equals.
    4) Join:
        Implement Join methods that combine multiple MyString objects (or an array of MyString) into a single string, using a separator string.
    5) EndsWith, StartsWith:
        Implement an EndsWith method that checks if the MyString ends with a given substring.
        Implement a StartsWith method that checks if the MyString starts with a given substring.
    6) Indexer:
        Implement an indexer to access individual characters in the MyString object by index (similar to the built-in string indexer).
    7) Operator+:
        Overload the + operator to allow concatenation of two MyString objects or a MyString object with a regular string.

*/

using System;
using MyStringNamespace;

class Program
{
    static void Main()
    {
        MyString str1 = new MyString("Hello World!");
        MyString str2 = new MyString("Hello World!");
        MyString[] strs = new MyString[2] { str1, str2 };
        string str3 = "Hello World!";

        Console.WriteLine($"String: {str1.String}");
        Console.WriteLine($"Compare : {str1.Compare(str2)}");
        Console.WriteLine($"Operator == : {str1 == str2}");
        Console.WriteLine($"Operator != : {str1 != str2}");
        Console.WriteLine($"Equals : {str1.Equals(str2)}");
        Console.WriteLine($"Equals with string: {MyString.Equals(str1, str2)}");
        Console.WriteLine($"Join: {MyString.Join('_', strs)}");
        Console.WriteLine($"Starts with: {str1.StartsWith("Hello")}");
        Console.WriteLine($"Ends with: {str2.EndsWith("World!")}");
        Console.WriteLine($"Indexer: {str1[0]}");
        Console.WriteLine($"Concatenation: {(str1 + str2).String}");
        Console.WriteLine($"Concatenation with string: {(str1 + str3).String}");

        Console.ReadKey();
    }
}