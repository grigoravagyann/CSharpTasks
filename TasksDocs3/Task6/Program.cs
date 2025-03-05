/*
Task 6: Employee Payroll System
Task: Create an Employee class with:
    1) Name, Position, SalaryPerHour, and HoursWorked.
    2) A method CalculateSalary() that returns SalaryPerHour * HoursWorked.
    3) In Main(), create 3 employees, calculate their salaries, and display them.
    4) If an employee works over 40 hours, pay overtime (1.5x rate).
*/


class Employee
{
    string _employeeName;
    string _employeePosition;
    double _employeeSalaryPerHour;
    double _employeeHoursWorked;
    public string Name
    {
        get { return _employeeName; }
    }
    public string Position
    {
        get { return _employeePosition; }
    }
    public double SalaryPerHour
    {
        get { return _employeeSalaryPerHour; }
    }
    public double HoursWorked
    {
        get { return _employeeHoursWorked; }
    }
    public Employee(string Name, string Position, double SalaryPerHour, double HoursWorked)
    {
        _employeeName = Name;
        _employeePosition = Position;
        _employeeSalaryPerHour = SalaryPerHour;
        _employeeHoursWorked = HoursWorked;
    }
    public double CalculateSalary()
    {
        return SalaryPerHour * HoursWorked;
    }
}

class MainClass
{
    public static int SIZE = 3;

    static void Main(string[] args)
    {
        Employee[] ourEmployers = new Employee[SIZE];
        for (int i=0; i<SIZE; ++i)
        {
            Console.WriteLine($"Enter information about Employee {i+1}. ");
            Console.Write($"Enter Name of Employee : ");
            string? employeeName = Console.ReadLine();
            Console.Write($"Enter Position of Employee : ");
            string? employeePosition = Console.ReadLine();
            Console.Write($"Enter Salary of Employee : ");
            double employeeSalary = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Enter Worked Hours of Employee : ");
            double employeeHoursWorked = Convert.ToDouble(Console.ReadLine());
            ourEmployers[i] = new Employee(employeeName!, employeePosition!, employeeSalary, employeeHoursWorked);
            Console.WriteLine();
        }
        for (int i=0; i<SIZE; ++i)
        {
            if (ourEmployers[i].HoursWorked > 40)
            {
                Console.WriteLine($"Salary of Employee {i+1}: {ourEmployers[i].SalaryPerHour*ourEmployers[i].HoursWorked*1.5} (Paid Overtime).");
            }
            else
            {
                Console.WriteLine($"Salary of Employee {i+1}: {ourEmployers[i].SalaryPerHour*ourEmployers[i].HoursWorked}.");
            }
        }
    }
}