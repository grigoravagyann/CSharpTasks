/*
Task 1: Student Management System
Task: Create a class Student with:
    1) Fields: name, studentID, and gradeLevel.
    2) Add a method ShowStudentInfo() to display the details.
    3) In Main(), create a few Student objects and display their details.
*/

class Student
{
    string? _studentName;
    string? _studentID;
    string? _studentGradeLevel;
    public string name
    {
        get { return _studentName!; }
    }
    public string StudentID
    {
        get { return _studentID!; }
    }
    public string GradeLevel
    {
        get { return _studentGradeLevel!; }
    }
    public Student() {}
    public Student(string studentName, string studentID, string studentGradeLevel)
    {
        this._studentName = studentName;
        this._studentID = studentID;
        this._studentGradeLevel = studentGradeLevel;
    }
    public void ShowStudentInfo()
    {
        Console.WriteLine($"Student Name: {_studentName}\nStudentID: {_studentID}\nStudent Grade Level: {_studentGradeLevel}");
    }
    public static Student CreateStudent()
    {
        Console.Write($"Enter name of the student: ");
        string? studentName = Console.ReadLine();
        Console.Write($"Enter ID of the student: ");
        string? studentID = Console.ReadLine();
        Console.Write($"Enter grade level of the student: ");
        string? studentGradeLevel = Console.ReadLine();
        Student newStudent = new Student(studentName!, studentID!,studentGradeLevel!);
    
        return newStudent;
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        Console.Write("How student objects you want to create? : ");
        int listSize = Convert.ToInt32(Console.ReadLine());
        List<Student> ourStudents = new List<Student>();
        for (int i = 0; i < listSize; ++i)
        {
            Student newStudent = Student.CreateStudent();
            ourStudents.Add(newStudent);
        }
        for (int i=0; i < listSize; ++i)
        {
            Console.WriteLine($"Information of Student {i+1}:");
            ourStudents[i].ShowStudentInfo();
        }

    }
}