class Program
{
    static void Main(string[] args)
    {
        string num1 = "101";
        string num2 = "-100";
        string result = SubstractStrings(num1, num2);
        Console.WriteLine(result);
    }
    static string SubstractStrings(string bigInt1, string bigInt2)
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

}