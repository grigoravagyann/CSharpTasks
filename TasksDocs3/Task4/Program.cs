/*
Task 4: Book Library
Task: Create a Book class with:
    1) Title, Author, IsAvailable properties.
    2) A method BorrowBook() that sets IsAvailable = false.
    3) A method ReturnBook() that sets IsAvailable = true.
    4) In Main(), create 3 books, borrow one, and display availability status.
    5) Allow user interaction (choose which book to borrow/return).
*/

using System;

class Book
{
    string _bookTitle;
    string _bookAuthor;
    bool _bookIsAvailable;

    public string Title
    {
        get { return _bookTitle; }
    }
    public string Author
    {
        get { return _bookAuthor; }
    }
    public bool IsAvailable
    {
        get { return _bookIsAvailable;}
    }
    public Book(string Title, string Author)
    {
        _bookTitle = Title;
        _bookAuthor = Author;
        _bookIsAvailable = true;
    }

    public void BorrowBook()
    {
        if(_bookIsAvailable)
        {
            _bookIsAvailable = false;
            Console.WriteLine($"You borrowed {Title} book of {Author} succesfully.");
        }
        else
        {
            Console.WriteLine("Book is not available!");
        }
    }
    public void ReturnBook()
    {
        if(_bookIsAvailable)
        {
            Console.WriteLine("You didn't borrow that book from us!");
        }
        else
        {
            _bookIsAvailable = true;
            Console.WriteLine($"You returned {Title} of {Author} succesfully.");
        }
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_bookTitle}\nAuthor: {_bookAuthor}\nIsAvailable: {IsAvailable}");
    }

}

class MainClass
{
    public static int SIZE = 3;

    static void Main(string[] args)
    {
        Book[] ourBooks = new Book[SIZE];
        ourBooks[0] = new Book("To kill a mockingbird", "Harper Lee");
        ourBooks[1] = new Book("The great gatsby", "Scott Fitzgerald");
        ourBooks[2] = new Book("1984", "George Orwell");

        Console.WriteLine("Hi! This is book library");
        while (true)
        {
            Console.WriteLine("We have this books:\n");
            for (int i=0; i<SIZE; ++i)
            {
                ourBooks[i].DisplayInfo();
                Console.WriteLine();
            }
            Label1:
            Console.Write("Do you want to borrow or to return book? Press {b/r} :  ");
            string? userAnswer = Console.ReadLine();
            if (userAnswer == null)
            {
                Console.WriteLine("Null reference! Try again.");
                goto Label1;
            }
            if (userAnswer == "B" || userAnswer == "b")
            {
                Console.Write("Which book you want to borrow?: ");
                string? borrowBook = Console.ReadLine();
                if (borrowBook == null)
                {
                    Console.WriteLine("Null reference! Try again.");
                    goto Label1;
                }
                for (int i = 0; i < SIZE; ++i)
                {
                    if (borrowBook!.Equals(ourBooks[i].Title))
                    {
                        ourBooks[i].BorrowBook();
                        break;
                    }
                    if (i == SIZE - 1)
                    {
                        Console.WriteLine($"We dont have book {borrowBook} in our library");
                    }
                }
            }
            else if (userAnswer == "R" || userAnswer == "r")
            {
                Console.Write("Which book you want to return?: ");
                string? returnBook = Console.ReadLine();
                if (returnBook == null)
                {
                    Console.WriteLine("Null reference! Try again.");
                    goto Label1;
                }
                for (int i = 0; i < SIZE; ++i)
                {
                    if (returnBook!.Equals(ourBooks[i].Title))
                    {
                        ourBooks[i].ReturnBook();
                        break;
                    }
                    if (i == SIZE - 1)
                    {
                        Console.WriteLine($"You didn't borrow that book from us! We didn't have that book in our library.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid answer! Try again.");
                goto Label1;
            }

            Label2:
            Console.Write("Do you want to borrow or return another one? Press {y/n} : ");
            userAnswer = Console.ReadLine();
            if (userAnswer == "Y" || userAnswer == "y")
            {
                continue;
            }
            else if (userAnswer == "N" || userAnswer == "n")
            {
                Console.WriteLine("Thank you for using our library! Good bye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid answer! Try again.");
                goto Label2;
            }   
        }
    }
}