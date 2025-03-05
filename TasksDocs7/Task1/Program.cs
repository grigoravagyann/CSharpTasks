/*
Task 1: Property with Lazy Initialization and Read-Only Constraint
Task: Create a Person class with the following:
    1) FirstName and LastName as auto-properties.
    2) A read-only property FullName that is computed only once when accessed for the first time (lazy initialization).
    3) Ensure FullName is stored internally and does not change if FirstName or LastName are modified.
*/

class Person
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    string? _personFullName;
    public string FullName
    {
        get
        {
            if( _personFullName == null)
                _personFullName = FirstName + LastName;

            return _personFullName!;
        }       
    }
}

class MainClass
{
    static void Main()
    {
        Person newPerson = new Person();
        newPerson.FirstName = "Grigor";
        newPerson.LastName = "Avagyan";
        string fullName = newPerson.FullName;
        Console.WriteLine(fullName);
        newPerson.FirstName = "Avagyan";
        newPerson.LastName = "Grigor";
        string fullName2 = newPerson.FullName;
        Console.WriteLine(fullName2);
    }
}