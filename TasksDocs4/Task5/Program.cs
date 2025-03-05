/*
Task 5: Smartwatch Step Counter
Task: Create a class Smartwatch with:
    1) Fields: ownerName and stepCount.
    2) Add methods AddSteps(int steps) and ShowSteps().
    3) In Main(), create a smartwatch object, simulate adding steps, and display the total.
*/

using System.Reflection.Emit;

class SmartWatch
{
    string? _watchOwnerName;
    int _watchStepCount;
    public string ownerName
    {
        get => _watchOwnerName!;
    }
    public int StepCount
    {
        get => _watchStepCount!;
    }
    public SmartWatch() {}
    public SmartWatch(string watchOwnerName, int watchStepCount)
    {
        this._watchOwnerName = watchOwnerName;
        this._watchStepCount = watchStepCount;
    }
    public void AddSteps(int stepCount)
    {
        if(stepCount >= 0)
        {
            _watchStepCount += stepCount;
        }
        else
        {
            Console.WriteLine("Invalid argument!.");
        }
    }
    public void ShowSteps()
    {
        Console.WriteLine($"You have walked {_watchStepCount} steps today.");
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        SmartWatch myWatch = new SmartWatch();
        while(true)
        {
            Console.Write("How steps owner walked? : ");
            int ownerSteps = Convert.ToInt32(Console.ReadLine());
            myWatch.AddSteps(ownerSteps);
            Console.WriteLine($"You have walked {myWatch.StepCount} steps for now.");
            Label:
            Console.Write("Add again or exit and show result for today? Press {a/e} : ");
            string? userAnswer = Console.ReadLine();
            if (userAnswer!.ToLower() == "a")
            {
                continue;
            }
            else if (userAnswer!.ToLower() == "e")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid answer! Try again.");
                goto Label;
            }
        }
        myWatch.ShowSteps();
    }
}