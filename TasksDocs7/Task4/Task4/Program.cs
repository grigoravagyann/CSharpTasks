/*
Task 4:  Student Grades
Task: Create a Students class that stores grades:
    1) Implement an indexer where:
        The key is a subject name.
        The value is a grade.
        If the subject doesn’t exist, return -1.
    2) Use only arrays.
*/

class Students
{
    int[]? _studentsGrades;
    string[]? _subjectsNames;
    public int this[string name]
    {
        get
        {
            for(int i=0; i < _subjectsNames!.Length; i++)
            {
                if (_subjectsNames[i] == name)
                {
                    return _studentsGrades![i];
                }
            }
            return -1;
        }
    }
    public Students(string[] Subjects, int[] Grades)
    {
        _studentsGrades = Grades;
        _subjectsNames = Subjects;
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        string[] subjects = { "Math", "Physics", "Chemistry", "Biology" };
        int[] grades = { 90, 80, 70, 60 };
        Students student = new Students(subjects, grades);
        Console.WriteLine(student["Math"]);
        Console.WriteLine(student["Physics"]);
        Console.WriteLine(student["Chemistry"]);
        Console.WriteLine(student["Biology"]);
        Console.WriteLine(student["English"]);
        Console.Read();
    }
}
