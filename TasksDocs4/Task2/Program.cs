/*
Task 2: Flight Reservation System
Task: Create a class FlightTicket with:
    1) Fields: passengerName, flightNumber, and seatNumber.
    2) Add a constructor to initialize these fields.
    3) In Main(), create a few tickets and print the details.
*/

class FlightTicket
{
    string? _ticketPassengerName;
    string? _ticketFlightNumber;
    string? _ticketSeatNumber;
    public string passengerName
    {
        get { return _ticketPassengerName!; }
    }
    public string FlightNumber
    {
        get { return _ticketFlightNumber!; }
    }
    public string SeatNumber
    {
        get { return _ticketSeatNumber!; }
    }
    public FlightTicket() {}
    public FlightTicket(string PassengerName,string FlightNumber,string SeatNumber)
    {
        this._ticketPassengerName = PassengerName;
        this._ticketFlightNumber = FlightNumber;
        this._ticketSeatNumber = SeatNumber;
    }
    public static FlightTicket CreateTicket()
    {
        Console.Write("Enter PassengerName: ");
        string? passengerName = Console.ReadLine();
        Console.Write("Enter FlightNumber: ");
        string? flightNumber = Console.ReadLine();
        Console.Write("Enter SeatNumber: ");
        string? seatNumber = Console.ReadLine();
        FlightTicket newTicket = new FlightTicket(passengerName!, flightNumber!, seatNumber!);

        return newTicket;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"PassengerName: {_ticketPassengerName}\nFlightNumber: {_ticketFlightNumber}\nSeatNumber: {_ticketSeatNumber}");
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        List<FlightTicket> ourTickets = new List<FlightTicket>();
        Console.Write("How tickets you want to create? : ");
        int ticketsCount = Convert.ToInt32(Console.ReadLine());
        for (int i=0; i < ticketsCount; ++i)
        {
            Console.WriteLine($"Enter details of Ticket {i+1}: ");
            FlightTicket newTicket = FlightTicket.CreateTicket();
            ourTickets.Add(newTicket);
        }
        for (int i=0; i < ticketsCount; ++i)
        {
            Console.WriteLine($"Information about Ticket {i+1}: ");
            ourTickets[i].DisplayInfo();
        }
    }
}