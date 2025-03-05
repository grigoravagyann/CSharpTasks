/*
Task 8: School System
Task: Create a School Management System with:
    1) Student class (Name, Age, Grade).
    2) Teacher class (Name, Subject, YearsOfExperience).
    3) School class that stores students & teachers in an array.
    4) Show students with the highest grade and teachers with less than 2 years experience.
*/

using System;

class Student
{
    string _studentName;
    int _studentAge;
    double _studentGrade;
    public string Name
    {
        get { return _studentName; }
    }
    public int Age
    {
        get { return _studentAge; }
    }
    public double Grade
    {
        get { return _studentGrade; }
    }
    public Student(string Name, int Age, double Grade)
    {
        _studentName = Name;
        _studentAge = Age;
        _studentGrade = Grade;
    }
    public static Student AddStudent()
    {
        Console.WriteLine("Enter student's name: ");
        string? studentName = Console.ReadLine();
        Console.WriteLine("Enter student's age: ");
        int studentAge = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter student's grade: ");
        double studentGrade = Convert.ToDouble(Console.ReadLine());

        return new Student(studentName!, studentAge, studentGrade);
    }
}
class Teacher
{
    string _teacherName;
    string _teacherSubject;
    double _teacherYearsOfExperience;
    public string Name
    {
        get { return _teacherName; }
    }
    public string Subject
    {
        get { return _teacherSubject; }
    }
    public double YearsOfExperience
    {
        get { return _teacherYearsOfExperience; }
    }
    public Teacher(string Name, string Subject, double YearsOfExperience)
    {
        _teacherName = Name;
        _teacherSubject = Subject;
        _teacherYearsOfExperience = YearsOfExperience;
    }
    public static Teacher AddTeacher()
    {
        Console.WriteLine("Enter teacher's name: ");
        string? teacherName = Console.ReadLine();
        Console.WriteLine("Enter teacher's subject: ");
        string? teacherSubject = Console.ReadLine();
        Console.WriteLine("Enter teacher's years of experience: ");
        double teacherYearsOfExperience = Convert.ToDouble(Console.ReadLine());

        return new Teacher(teacherName!, teacherSubject!, teacherYearsOfExperience);
    }
}
class School
{
    Student[] _schoolStudents;
    Teacher[] _schoolTeachers;
    public Student[] Students
    {
        get { return _schoolStudents; }
    }
    public Teacher[] Teachers
    {
        get { return _schoolTeachers; }
    }
    public School(Student[] Students, Teacher[] Teachers)
    {
        _schoolStudents = Students;
        _schoolTeachers = Teachers;
    }
    public void HighestGrades()
    {
        for (int i=0; i < _schoolStudents.Length; ++i)
        {
            for(int j=0; j < _schoolStudents.Length - 1; ++j)
            {
                if(_schoolStudents[j].Grade > _schoolStudents[j+1].Grade)
                {
                    Student tmp = _schoolStudents[j];
                    _schoolStudents[j] = _schoolStudents[j+1];
                    _schoolStudents[j+1] = tmp;
                }
            }
        }
        Console.WriteLine("Students with highest grades");
        for (int i=1; i <= 3; ++i)
        {
            Console.WriteLine($"   {_schoolStudents[_schoolStudents.Length - i].Name} with grade {_schoolStudents[_schoolStudents.Length - i].Grade}");
            if( _schoolStudents.Length - i - 1 < 0)
            {
                break;
            }
        }
    }
    public void LessThan2()
    {
        Console.WriteLine("Teachers with less than 2 years experience.");
        for(int i=0; i < _schoolTeachers.Length; ++i)
        {
            if(_schoolTeachers[i].YearsOfExperience < 2)
            {
                Console.WriteLine($"   {_schoolTeachers[i].Name} with {_schoolTeachers[i].YearsOfExperience} years of experience");
            }
        }
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        Console.Write("How students are in school? ");
        int studentsSize = Convert.ToInt32(Console.ReadLine());
        Console.Write("How teachers are in school? ");
        int teachersSize = Convert.ToInt32(Console.ReadLine());
        Student[] ourStudents = new Student[studentsSize];
        Teacher[] ourTeachers = new Teacher[teachersSize];
        for (int i = 0; i < studentsSize; ++i)
        {
            Console.WriteLine($"Enter information about student {i+1}.");
            ourStudents[i] = Student.AddStudent();
        }
        for (int i = 0; i < teachersSize; ++i)
        {
            Console.WriteLine($"Enter information about teacher {i+1}.");
            ourTeachers[i] = Teacher.AddTeacher();
        }
        School ourSchool = new School(ourStudents, ourTeachers);
        ourSchool.HighestGrades();
        ourSchool.LessThan2();
    }
}