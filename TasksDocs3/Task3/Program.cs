 /*
 Task 3: Bank Account
 Task: Create a BankAccount class with:
     1) AccountNumber, HolderName, Balance.
     2) Methods Deposit(amount) and Withdraw(amount), ensuring balance never goes negative.
     3) In Main(), allow the user to create an account and perform deposits/withdrawals.
     4) Prevent withdrawal if insufficient funds and show an error message.
*/

using System;

class BankAccount
{
    string _accountNumber;
    string _accountHolderName;
    double _accountBalance;

    public string AccountNumber
    {
        get { return _accountNumber; }
    }
    public string HolderName
    {
        get { return _accountHolderName; }
    }
    public double Balance
    {
        get { return _accountBalance; }
    }
    public BankAccount(string accountNumber, string accountHolderName)
    {
        _accountNumber = accountNumber;
        _accountHolderName = accountHolderName;
        _accountBalance = 0;
    }

    public void Deposit(int depositAmount)
    {
        _accountBalance += depositAmount;
        Console.WriteLine($"You deposited {depositAmount} to your balance. Balance: {_accountBalance}");
    }

    public int Withdraw(int withdrawAmount)
    {
        if(_accountBalance < withdrawAmount)
        {
            Console.WriteLine($"Insufficient funds!!! Balance: {_accountBalance} $");
            return 0;
        }
        else
        {
            _accountBalance -= withdrawAmount;
            Console.WriteLine($"You withdrawed {withdrawAmount} from your balance. Balance: {_accountBalance} $");
            return withdrawAmount;
        }
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"AccountNumber: {_accountNumber}\nHolderName: {_accountHolderName}\nBalance: {_accountBalance}");
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Creating your bank account...");
        Console.WriteLine("Enter details of your account");
        Console.Write("AccountNumber: ");
        string? accountNumber = Console.ReadLine();
        Console.Write("HolderName: ");
        string? accountHolderName = Console.ReadLine();
        BankAccount myBankAccount = new BankAccount(accountNumber!, accountHolderName!);
        while (true)
        {
            Label1:
            Console.Write("Do you want to deposit or withdraw money? Press {d/w} : ");
            string? userAnswer = Console.ReadLine();
            if (userAnswer == null)
            {
                Console.WriteLine("Null reference! Try again.");
                goto Label1;
            }
            if (userAnswer == "D" || userAnswer == "d")
            {
                Console.Write("How much money you want to deposit? : ");
                int depositAnswer = Convert.ToInt32(Console.ReadLine());
                if(depositAnswer <= 0)
                {
                    Console.WriteLine("Invalid value! Try again.");
                    goto Label1;
                }
                myBankAccount.Deposit(depositAnswer!);
            }
            else if (userAnswer == "W" || userAnswer == "w")
            {
                Console.Write("How much money you want to withdraw? : ");
                int withdrawAnswer = Convert.ToInt32(Console.ReadLine());
                if(withdrawAnswer <= 0)
                {
                    Console.WriteLine("Invalid value! Try again.");
                    goto Label1;
                }
                myBankAccount.Withdraw(withdrawAnswer);
            }
            else
            {
                Console.WriteLine("Invalid answer! Try again.");
                goto Label1;
            }
            
            Label2:
                Console.Write("Do you want to do deposit or withdraw again? Press {y/n} : ");
                userAnswer = Console.ReadLine();
                if (userAnswer == null)
                {
                    Console.WriteLine("Null reference! Try again.");
                    goto Label1;
                }
                if (userAnswer == "Y" || userAnswer == "y")
                {
                    continue;
                }
                else if (userAnswer == "N" || userAnswer == "n")
                {
                    Console.WriteLine("Thank you for using our bank! Good bye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid answer! Try again.");
                    goto Label2;
                }
        }
    }
}

