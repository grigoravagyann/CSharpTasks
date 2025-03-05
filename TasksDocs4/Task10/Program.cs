/*
Task 10: Simulating Course Enrollment
Task: Create a class Course with:
    1) Fields: courseName, instructor, and maxStudents.
    2) Use a constructor to initialize these fields.
    3) Add a method ShowCourseDetails().
    4) In Main(), create a few courses and display their details.
*/

class Course
{
    string? _courseName;
    string? _courseInstructor;
    string? _courseMaxStudents;
    public string CourseName
    {
        get => _courseName!;
    }
    public string CourseInstructor
    {
        get => _courseInstructor!;
    }
    public string MaxStudents
    {
        get => _courseMaxStudents!;
    }
    public Course(string courseName, string courseInstructor, string courseMaxStudents)
    {
        this._courseName = courseName;
        this._courseInstructor = courseInstructor;
        this._courseMaxStudents = courseMaxStudents;
    }
    public void ShowCourseDetails()
    {
        Console.WriteLine($"CourseName: {_courseName}, Instructor: {_courseInstructor}, MaxStudents: {_courseMaxStudents}");
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        Course[] myCourses = new Course[3];
        for (int i = 0; i < myCourses.Length; ++i)
        {
            Console.WriteLine($"Enter details of course {i+1}:");
            Console.Write("Enter course name: ");
            string? courseName = Console.ReadLine();
            Console.Write("Enter course instructor name: ");
            string? courseInstructor = Console.ReadLine();
            Console.Write("Enter students maximum count: ");
            string? courseMaxStudents = Console.ReadLine();

            myCourses[i] = new Course(courseName!, courseInstructor!, courseMaxStudents!);
        }
        Console.WriteLine("Courses and details:");
        for ( int i=0; i < myCourses.Length; ++i)
        {
            myCourses[i].ShowCourseDetails();
        }
    }
}