/*
Task 7: Ticket Booking System
Task: Create a MovieTicket class with:
    1) MovieName, SeatNumber, IsBooked.
    2) A method BookTicket() that marks it as booked.
    3) In Main(), create 5 seats, allow the user to book one, and prevent double booking.
    4) Show all available seats before booking.
*/


using System;

class MovieTicket
{
    string _ticketMovieName;
    int _ticketSeatNumber;
    bool _ticketIsBooked;
    public string MovieName
    {
        get { return _ticketMovieName; }
    }
    public int SeatNumber
    {
        get { return _ticketSeatNumber; }
    }
    public bool IsBooked
    {
        get { return _ticketIsBooked; }
    }
    public MovieTicket(string MovieName, int SeatNumber)
    {
        _ticketMovieName = MovieName;
        _ticketSeatNumber = SeatNumber;
        _ticketIsBooked = false;
    }
    public void BookTicket()
    {
        if(_ticketIsBooked == false)
        {
            _ticketIsBooked = true;
            Console.WriteLine($"You booked ticket for {MovieName} movie in seat {SeatNumber+1} succesfully.");
        }
        else
        {
            Console.WriteLine($"Seat for {MovieName} movie in seat {SeatNumber+1} is already booked.");
        }
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        int SIZE = 5;
        MovieTicket[] ourTickets = new MovieTicket[SIZE];
        for (int i = 0; i < SIZE; ++i)
        {
            ourTickets[i] = new MovieTicket("Spider-Man", i);
        }

        Console.WriteLine("Welcome to our cinema.");
        while (true)
        {
            Console.WriteLine("Available seats:");
            for (int i = 0; i < SIZE; ++i)
            {
                int flag = 0;
                if (ourTickets[i].IsBooked == false)
                {
                    Console.WriteLine($"Seat {ourTickets[i].SeatNumber + 1} for Spider-Man is available");
                    flag = 1;
                }
                if(i == SIZE - 1)
                {
                    if( flag == 0)
                    {
                        Console.WriteLine("No available seats in Spider-Man movie.");
                        return;
                    }
                }
            }
            Console.Write("What seat do you want to book? : ");
            int userAnswer = Convert.ToInt32(Console.ReadLine());
            ourTickets[--userAnswer].BookTicket();
            Label:
            Console.Write("Do you want to book another one? Press {y/n} : ");
            string? userAnswerr = Console.ReadLine();
            if (userAnswerr!.ToLower() == "y")
            {
                continue;
            }
            else if ( userAnswerr.ToLower() == "n")
            {
                break;
            }
            Console.WriteLine("Invalid answer! Try again.");
            goto Label;
        }
    }
}