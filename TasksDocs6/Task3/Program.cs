/*
Task 3:  Implement a BigInt Class in C#
Task: Implement a custom BigInt class in C# to handle arbitrarily large integers using strings or arrays.
    1) Class Definition:
        Create a BigInt class with an appropriate private field (e.g., a string) to store large numbers.
    2) Constructors:
        A constructor that takes a string as input and initializes the BigInt object.
        A constructor that takes an int for small numbers.
    3) Properties:
        A Length property that returns the number of digits in the BigInt.
    4) Overloaded Operators:
        Implement +, -, *, and ==, !=, <, >, <=, >= for BigInt objects.
        Ensure the subtraction operator works correctly for positive and negative results.
        Implement multiplication without directly converting to int or long.
    5) Methods:
        ToString(): Converts the BigInt object into a string
        Abs(): Returns the absolute value of the BigInt.
        CompareTo(BigInt other): Compare two BigInt objects.
*/

using System.Data;
using System.Numerics;

class BigInt
{
    string? _bigIntNumber;
    public string BigIntNumber
    {
        get => _bigIntNumber!;
    }
    public BigInt(string? strNumber)
    {
        _bigIntNumber = strNumber;
    }
    public BigInt(int intNumber)
    {
        _bigIntNumber = intNumber.ToString();
    }

    public int bigIntLength => _bigIntNumber!.StartsWith("-") ? _bigIntNumber.Length - 1 : _bigIntNumber.Length;

    public static BigInt operator +(BigInt bigInt1, BigInt bigInt2) => new BigInt(AddStrings(bigInt1._bigIntNumber!, bigInt2._bigIntNumber!));
    public static string AddStrings(string bigInt1, string bigInt2)
    {
        int i = bigInt1.Length - 1;
        int j = bigInt2.Length - 1;
        int carry = 0;
        string resultString = "";
        while (i >= 0 || j >= 0 || carry > 0)
        {
            int digit1 = (i >= 0) ? bigInt1[i] - '0' : 0;
            int digit2 = (j >= 0) ? bigInt2[j] - '0' : 0;
            int sum = digit1 + digit2 + carry;
            carry = sum / 10;
            resultString = (sum % 10) + resultString;
            --i;
            --j;
        }
        return resultString;
    }
    public static BigInt operator -(BigInt bigInt1, BigInt bigInt2) => new BigInt(SubstractStrings(bigInt1._bigIntNumber!, bigInt2._bigIntNumber!));
    public static string SubstractStrings(string bigInt1, string bigInt2)
    {
        if (bigInt1[0] != '-' && bigInt2[0] == '-')
        {
            return AddStrings(bigInt1, bigInt2.TrimStart('-'));
        }
        else if ( bigInt1[0] == '-' && bigInt2[0] != '-' )
        {
            return "-" + AddStrings(bigInt1.TrimStart('-'), bigInt2);
        } 
        else if (bigInt1[0] == '-' && bigInt2[0] == '-')
        {
            if (CompareStrings(bigInt1.TrimStart('-'), bigInt2.TrimStart('-')) == 1 ) 
                return "-" + SubstractStrings(bigInt1.TrimStart('-'), bigInt2.TrimStart('-'));
            if (CompareStrings(bigInt1.TrimStart('-'), bigInt2.TrimStart('-')) == -1)
                return SubstractStrings(bigInt2.TrimStart('-'), bigInt1.TrimStart('-'));
        }
        else if (CompareStrings(bigInt1,bigInt2) == -1)
        {
            return "-" + SubstractStrings(bigInt2,bigInt1);
        }
        int i = bigInt1.Length - 1;
        int j = bigInt2.Length - 1;
        int borrow = 0;
        string resultString = "";
        while (i >= 0)
        {
            int digit1 = (i >= 0) ? bigInt1[i] - '0' : 0;
            int digit2 = (j >= 0) ? bigInt2[j] - '0' : 0;
            digit1 -= borrow;
            if(digit1 < digit2)
            {
                digit1 += 10;
                borrow = 1;
            }
            else
            {
                borrow = 0;
            }
            resultString = (digit1 - digit2) + resultString;
            --i;
            --j;
        }
        return resultString.TrimStart('0') ;
    }

    public static BigInt operator *(BigInt bigInt1, BigInt bigInt2) => new BigInt(MultiplyStrings(bigInt1._bigIntNumber!, bigInt2._bigIntNumber!));
    public static string MultiplyStrings(string bigInt1, string bigInt2)
    {
        if (bigInt1 == "0" || bigInt2 == "0") return "0";

        int lengthBigInt1 = bigInt1.Length;
        int lengthBigInt2 = bigInt2.Length;
        int[] result = new int[lengthBigInt1 + lengthBigInt2];

        for (int i = lengthBigInt1-1; i >= 0; i--)
        {
            for (int j = lengthBigInt2 - 1; j >= 0; j--)
            {
                int mul = (bigInt1[i] - '0') * (bigInt2[j] - '0');
                int sum = mul + result[i+j+1];

                result[i+j+1] = sum % 10;
                result[i+j] += sum / 10;
            }
        }
        string resultString = string.Join("", result).TrimStart('0');
        return resultString;
    }
    //public static BigInt operator /(BigInt bigInt1, BigInt bigInt2) => new BigInt(DivideStrings(bigInt1._bigIntNumber!, bigInt2._bigIntNumber!));
    // public static string DivideStrings(string bigInt1, string bigInt2)
    // {
        
    // }

    public static bool operator ==(BigInt bigInt1, BigInt bigInt2) => bigInt1._bigIntNumber == bigInt2._bigIntNumber;
    public static bool operator !=(BigInt bigInt1, BigInt bigInt2) => bigInt1._bigIntNumber != bigInt2._bigIntNumber;
    public static bool operator <(BigInt bigInt1, BigInt bigInt2) => CompareStrings(bigInt1._bigIntNumber!,bigInt2._bigIntNumber!) < 0;
    public static bool operator >(BigInt bigInt1, BigInt bigInt2) => CompareStrings(bigInt1._bigIntNumber!,bigInt2._bigIntNumber!) > 0;
    public static bool operator <=(BigInt bigInt1, BigInt bigInt2) => CompareStrings(bigInt1._bigIntNumber!,bigInt2._bigIntNumber!) <= 0;
    public static bool operator >=(BigInt bigInt1, BigInt bigInt2) => CompareStrings(bigInt1._bigIntNumber!,bigInt2._bigIntNumber!) >= 0;

    public override string ToString() => _bigIntNumber!;
    public static int CompareStrings(string bigInt1, string bigInt2)
    {
        if (bigInt1 == bigInt2)
            return 0;
        if (bigInt1[0] == '-' && bigInt2[0] != '-')
            return -1;
        if (bigInt1[0] != '-' && bigInt2[0] == '-')
            return 1;

        bool isBothNegative = (bigInt1[0] == '-');
        string num1 = bigInt1.TrimStart('-');
        string num2 = bigInt2.TrimStart('-');

        if (num1.Length > num2.Length)
            return isBothNegative ? -1 : 1;
        if (num1.Length < num2.Length)
            return isBothNegative ? 1 : -1;

        for (int i = 0; i < num1.Length; i++)
        {
            if (num1[i] > num2[i])
                return isBothNegative ? -1 : 1;
            if (num1[i] < num2[i])
                return isBothNegative ? 1 : -1;
        }

        return 0;
    }
    public BigInt Abs() => _bigIntNumber!.StartsWith("-") ? new BigInt(_bigIntNumber.Substring(1)) : this;
    public string CompareTo(BigInt other)
    {
        if (this._bigIntNumber! == other._bigIntNumber!)
            return "Numbers are equal";
        if (this._bigIntNumber![0] == '-' && other._bigIntNumber![0] != '-')
            return "Second number is greater";
        if (this._bigIntNumber![0] != '-' && other._bigIntNumber![0] == '-')
            return "First number is greater";

        bool isBothNegative = (this._bigIntNumber![0] == '-');
        string num1 = this._bigIntNumber!.TrimStart('-');
        string num2 = other._bigIntNumber!.TrimStart('-');

        if (num1.Length > num2.Length)
            return isBothNegative ? "Second number is greater" : "First number is greater";
        if (num1.Length < num2.Length)
            return isBothNegative ? "First number is greater" : "Second number is greater";

        for (int i = 0; i < num1.Length; i++)
        {
            if (num1[i] > num2[i])
                return isBothNegative ? "Second number is greater" : "First number is greater";
            if (num1[i] < num2[i])
                return isBothNegative ? "First number is greater" : "Second number is greater";
        }

        return "Numbers are equal";
    }


    public override bool Equals(object? bigInt)
{
    if (bigInt == null || !(bigInt is BigInt))
        return false;

    BigInt other = (BigInt)bigInt;
    return this._bigIntNumber == other._bigIntNumber;
}
public override int GetHashCode()
{
    return _bigIntNumber!.GetHashCode();
}

}

class MainClass
{
    static void Main(string[] args)
    {
        BigInt bigInt1 = new BigInt("1000000000000000000000000000000000000");
        BigInt bigInt2 = new BigInt("999999999999999999999999999999999999");
        Console.WriteLine($"Length: {bigInt1.bigIntLength}");
        Console.WriteLine($"+: {bigInt1+bigInt2}");
        Console.WriteLine($"-: {bigInt1-bigInt2}");
        Console.WriteLine($"*: {bigInt1*bigInt2}");
        //Console.WriteLine($"/: {bigInt2/bigInt1}");
        Console.WriteLine($"==: {bigInt1==bigInt2}");
        Console.WriteLine($"!=: {bigInt1!=bigInt2}");
        Console.WriteLine($"<: {bigInt1<bigInt2}");
        Console.WriteLine($">: {bigInt1>bigInt2}");
        Console.WriteLine($"<=: {bigInt1<=bigInt2}");
        Console.WriteLine($">=: {bigInt1>=bigInt2}");
        Console.WriteLine($"ToString: {bigInt1.ToString()}");
        Console.WriteLine($"Abs: {bigInt1.Abs()}");
        Console.WriteLine($"CompareTo: {bigInt1.CompareTo(bigInt2)}");
        Console.ReadLine();
    }
}