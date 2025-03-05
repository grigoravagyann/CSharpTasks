/* 
    Task 1: Phone Book
    Task: Create a Contact class with:
        1) Name, phoneNumber, and Email properties.
        2) A method DisplayInfo() to print contact details.
        3) A Main() method where the user can create 3 contacts and display them.
        4) Store contacts in an array and allow searching by name.
*/

using System;

class Contact
{
    string _contactName;
    string _contactPhoneNumber;
    string _contactEmail;

    public string Name
    {
        get { return _contactName; }
    }
    public string PhoneNumber
    {
        get { return _contactPhoneNumber; }
    }
    public string Email
    {
        get { return _contactEmail; }
    }
    public Contact(string contactName, string contactPhoneNumber, string contactEmail)
    {
        _contactName = contactName;
        _contactPhoneNumber = contactPhoneNumber;
        _contactEmail = contactEmail;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {_contactName}\nPhone number: {_contactPhoneNumber}\nEmail: {_contactEmail}");
    }
}

class MainClass
{
    public static int SIZE;

    static void Main(string[] args)
    {
        Console.WriteLine("How contacts will be in your phonebook?");
        int SIZE = int.Parse(Console.ReadLine()!);

        Contact[] myContacts = new Contact[SIZE];
        for (int i=0; i < SIZE; ++i)
        {
            Console.WriteLine($"Enter details of contact {i+1}");
            Console.Write("Name: ");
            string? contactName = Console.ReadLine();
            Console.Write("Phone number: ");
            string? contactPhoneNumber = Console.ReadLine();
            Console.Write("Email: ");
            string? contactEmail = Console.ReadLine();
            myContacts[i] = new Contact(contactName!, contactPhoneNumber!, contactEmail!);
        }

        for (int i=0; i < SIZE; ++i )
        {
            Console.WriteLine($"Details of contact {i+1} ");
            myContacts[i].DisplayInfo();
        }

        SearchingByName(myContacts);
    }

    public static void SearchingByName(Contact[] myContacts)
    {
        Console.Write("Enter the name of contact you want to search: ");
        string? searchingName = Console.ReadLine();
        Console.WriteLine("Searching...");
        for (int i=0; i < SIZE; ++i)
        {
            if (searchingName == myContacts[i].Name)
            {
                Console.WriteLine($"It is contact {i+1}.");
                break;
            }
            if (i == SIZE-1)
            {
                Console.WriteLine("No such contact...");
            }
        }
    }
}