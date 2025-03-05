/*
Task 1: Bank Account System with Custom Object Comparisons
Task: Develop a BankAccount class that supports:
    1) Custom String Representation (ToString() Override)
    Format: "Account: [AccountNumber], Balance: [Balance] USD"
    2) Equality Check (Equals() and GetHashCode())
    Two accounts are equal if they have the same AccountNumber.
    3) Overloaded + and - Operators for Transactions
    + should deposit money.
    - should withdraw money but prevent overdraft.
    4) Comparison Operators (>, <, >=, <=)
    Compare accounts based on balance.
*/
class BankAccount
{
    string? _accountNumber;
    double _accountBalance;
    public string AccountNumber
    {
        get => _accountNumber!;
    }
    public double AccountBalance
    {
        get => _accountBalance;
        set => _accountBalance = value;
    }
    public BankAccount(string accountNumber)
    {
        _accountNumber = accountNumber;
        _accountBalance = 0;
    }
    private BankAccount(string accountNumber, double accountBalance)
    {
        _accountNumber = accountNumber;
        _accountBalance = accountBalance;
    }
    public override int GetHashCode()
    {
        return _accountNumber!.GetHashCode() ^ _accountBalance.GetHashCode();
    }
    public override bool Equals(object? obj)
    {
        if (obj == null || obj is not BankAccount)
            return false;
        BankAccount bankAccount = (BankAccount)obj;
        return _accountNumber == bankAccount.AccountNumber;
    }
    public override string ToString()
    {
        Console.WriteLine($"\nAccount: {_accountNumber}, Balance: {_accountBalance} USD\n");
        return null!;
    }
    public static BankAccount operator +(BankAccount bankAccount,double depositAmount)
    {
        bankAccount._accountBalance += depositAmount;
        Console.WriteLine($"Successfully deposited {depositAmount} USD to your balance. Balance {bankAccount._accountBalance} USD\n");
        return new BankAccount(bankAccount._accountNumber!, bankAccount._accountBalance);
    }
    public static BankAccount operator -(BankAccount bankAccount,double withdrawAmount)
    {
        if(bankAccount._accountBalance < withdrawAmount)
        {
            Console.WriteLine($"There aren't {withdrawAmount} USD in your balance. Balance: {bankAccount._accountBalance} USD\n");
            return bankAccount;
        }
        bankAccount._accountBalance -= withdrawAmount;
        Console.WriteLine($"Successfully withdrawed {withdrawAmount} USD from your balance. Balance: {bankAccount._accountBalance} USD\n");
        return new BankAccount(bankAccount._accountNumber!, bankAccount._accountBalance);;
    }
    public static bool operator >(BankAccount bankAccount1,BankAccount bankAccount2)
    {
        return bankAccount1._accountBalance > bankAccount2._accountBalance;
    }
    public static bool operator <(BankAccount bankAccount1,BankAccount bankAccount2)
    {
        return bankAccount1._accountBalance > bankAccount2._accountBalance;
    }
    public static bool operator >=(BankAccount bankAccount1,BankAccount bankAccount2)
    {
        return bankAccount1._accountBalance >= bankAccount2._accountBalance;
    }
    public static bool operator <=(BankAccount bankAccount1,BankAccount bankAccount2)
    {
        return bankAccount1._accountBalance <= bankAccount2._accountBalance;
    }
    public static void Transactions(BankAccount bankAccount)
    {
        Label:
        Console.Write("For balance check press {i}.\nFor deposit press {d}.\nFor withdraw press {w}.\nFor exit press {e}.\nCommand: ");
        string? userAnswer = Console.ReadLine();
        if (userAnswer == null)
        {
            Console.WriteLine("Invalid value! Try again.\n");
            goto Label;
        }
        if(userAnswer!.ToLower() == "i")
        {
            Console.WriteLine(bankAccount);
            goto Label;
        }
        else if (userAnswer!.ToLower() == "d")
        {
            Console.Write("\nEnter money for deposit: ");
            double depositAmount = Convert.ToDouble(Console.ReadLine());
            if (depositAmount < 0)
            {
                Console.WriteLine("Invalid value! Try again.\n");
                goto Label;
            }
            bankAccount = bankAccount + depositAmount;
            goto Label;
        }
        else if (userAnswer.ToLower() == "w")
        {
            Console.Write("\nEnter money for withdraw: ");
            double withdrawAmount = Convert.ToDouble(Console.ReadLine());
            if (withdrawAmount < 0)
            {
                Console.WriteLine("Invalid value! Try again.\n");
                goto Label;
            }
            bankAccount = bankAccount - withdrawAmount;
            goto Label;
        }
        else if (userAnswer.ToLower() == "e")
        {
            Console.WriteLine("Thank you for using our bank! Good Bye.");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Invalid command! Try again.");
            goto Label;
        }
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        BankAccount bankAccount = new BankAccount($"15700001");
        BankAccount.Transactions(bankAccount);
    }
}