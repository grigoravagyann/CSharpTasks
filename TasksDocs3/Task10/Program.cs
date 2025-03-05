/*
Task 10: To-Do List Application
Task: Create a TaskItem class with:
    1) Description, IsCompleted.
    2) Methods MarkComplete() and MarkIncomplete().
    3) Store multiple tasks in a list and allow users to add, remove, or mark tasks as complete.
*/

using System.Reflection.Emit;

class TaskItem
{
    string? _taskDescription;
    bool _taskIsCompleted;
    public string Description
    {
        get { return _taskDescription!; }
    }
    public bool IsCompleted
    {
        get { return _taskIsCompleted;}
    }
    public TaskItem(string? taskDescription)
    {
        _taskDescription = taskDescription;
        _taskIsCompleted = false;
    }
    public void MarkComplete()
    {
        if (_taskIsCompleted == false)
        {
            _taskIsCompleted = true;
            Console.WriteLine("Task marked completed succesfully.");
        }
        else
        {
            Console.WriteLine("Task is already marked completed.");
        }
    }
    public void MarkInComplete()
    {
        if(_taskIsCompleted == true)
        {
            _taskIsCompleted = false;
            Console.WriteLine("Task marked incomplete succesfully.");
        }
        else
        {
            Console.WriteLine("Task is already marked incompleted.");
        }
    }
}

class MainClass
{
    public static void Main()
    {
        List<TaskItem> myTasks = new List<TaskItem>();
        int taskCount = 1;
        Console.WriteLine("Welcome to To-Do List Application!");
        Console.Write("How many tasks you want to make? : ");
        int SIZE = Convert.ToInt32(Console.ReadLine());
        for(int i=0; i < SIZE; ++i)
        {
            Console.Write($"Enter description for Task {taskCount++} : ");
            string? taskDescription = Console.ReadLine();
            TaskItem newTask = new TaskItem(taskDescription);
            myTasks.Add(newTask);
        }
        while(true)
        {
            Console.WriteLine("Your tasks: ");
            for(int i=0; i < SIZE; ++i)
            {
                Console.WriteLine($"Task {i+1}) {myTasks[i].Description} - " + (myTasks[i].IsCompleted ?  "Completed." : "Not completed."));
            }
            Label:
            if(SIZE == 0)
            {
                Console.WriteLine("No tasks add or exit!");
                goto Label3;
            }
            Console.Write("Do you want to mark any task? Press {y/n} : ");
            string? userAnswer = Console.ReadLine();
            if (userAnswer!.ToLower() == "n")
            {
                goto Label3;
            }
            else if(userAnswer!.ToLower() != "y" )
            {
                Console.WriteLine("Invalid answer! Try again.");
                goto Label;
            }
            Console.Write("What task you want to mark? : ");
            int userAnswer2 = Convert.ToInt32(Console.ReadLine());
            if(userAnswer2 > SIZE || userAnswer2 <= 0)
            {
                Console.WriteLine("Invalid answer! Try again.");
                goto Label;
            }
            Label2:
            Console.Write("Do you want to mark complete or incomplete? Press {c/i} : "); 
            userAnswer = Console.ReadLine();
            if(userAnswer!.ToLower() == "c")
            {
                myTasks[userAnswer2-1].MarkComplete();
            }
            else if (userAnswer!.ToLower() == "i")
            {
                myTasks[userAnswer2-1].MarkInComplete();
            }
            else
            {
                Console.WriteLine("Invalid answer! Try again.");
                goto Label2;
            }
            Label3:
            Console.Write("Do you want to Add, Remove, Mark item or Exit? {Add/Remove/Mark/Exit} : ");
            userAnswer = Console.ReadLine();
            if (userAnswer!.ToLower() == "add")
            {
                Console.Write($"Enter description for Task {taskCount++} : ");
                string? taskDescription = Console.ReadLine();
                TaskItem newTask = new TaskItem(taskDescription);
                myTasks.Add(newTask);
                SIZE++;
                goto Label3;
            }
            else if (userAnswer!.ToLower() == "remove")
            {
                Console.Write("Which task you want to remove? : ");
                userAnswer2 = Convert.ToInt32(Console.ReadLine());
                myTasks.Remove(myTasks[userAnswer2-1]);
                SIZE--;
                goto Label3;
            }
            else if (userAnswer!.ToLower() == "mark")
            {
                continue;
            }
            else if (userAnswer!.ToLower() == "exit")
            {
                break;
            }
        }
    }
}