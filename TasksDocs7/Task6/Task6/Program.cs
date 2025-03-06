/*
Task 6: Read - Only Indexer for Contact List
Task: Create a ContactArray class that :
    1) Stores contacts as Person objects.
    2) Allows searching contacts by ID or Name using two separate indexers.
    3) Returns null if no contact is found.
*/

class ContactArray
{
    Person[] _contacts;
    public Person[] Contacts => _contacts;
    public ContactArray(int size)
    {
        _contacts = new Person[size];
    }
    public string this[int id]
    {
        get
        {
            foreach (var contact in _contacts)
            {
                if (contact._personID == id)
                {
                    return contact.Name;
                }
            }
            return null!;
        }
    }
    public string this[string name]
    {
        get
        {
            foreach (var contact in _contacts)
            {
                if (contact.Name == name)
                {
                    return contact.ID.ToString();
                }
            }
            return null!;
        }
    }
}

class Person
{
    string? _personName;
    public int _personID;
    public string? Name => _personName;
    public int ID => _personID;
    public Person(int id, string name)
    {
        _personID = id;
        _personName = name;
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        ContactArray contacts = new ContactArray(3);
        contacts.Contacts[0] = new Person(1, "Ali");
        contacts.Contacts[1] = new Person(2, "Ahmed");
        contacts.Contacts[2] = new Person(3, "Sara");
        Console.WriteLine(contacts[1]); // Ali
        Console.WriteLine(contacts["Ahmed"]); // 2
        Console.ReadLine();
    }
}