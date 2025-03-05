 /*
    Task 2: Student Management
    Task: Create a Student class with:
        1) Name, Age, and Grade properties.
        2) A DisplayDetails() method.
        3) In Main(), create 5 students, store them in an array, and display their details.
*/

using System;

class Student
{
    string _studentName;
    string _studentAge;
    string _studentGrade;

    public string Name
    {
        get { return _studentName; }
    }
    public string Age
    {
        get { return _studentAge; }
    }
    public string Grade
    {
        get { return _studentGrade; }
    }
    public Student(string studentName, string studentAge, string studentGrade)
    {
        _studentName = studentName;
        _studentAge = studentAge;
        _studentGrade = studentGrade;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Name: {_studentName}\nAge: {_studentAge}\nGrade: {_studentGrade}");
    }
}

class MainClass
{
    public static int SIZE = 5;

    static void Main(string[] args)
    {
        Student[] ourStudents = new Student[SIZE];
        for (int i=0; i < SIZE; ++i )
        {
            Console.WriteLine($"Enter details of student {i+1}");
            Console.Write("Name: ");
            string? studentName = Console.ReadLine();
            Console.Write("Age: ");
            string? studentAge = Console.ReadLine();
            Console.Write("Grade: ");
            string? studentGrade = Console.ReadLine();
            ourStudents[i] = new Student(studentName!, studentAge!, studentGrade!);
        }
        for (int i=0; i < SIZE; ++i )
        {
            Console.WriteLine($"Details of student {i+1} ");
            ourStudents[i].DisplayDetails();
        }
    }
}