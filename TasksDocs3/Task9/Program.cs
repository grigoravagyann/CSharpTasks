/*
Task 9: Car Rental System
Task: Create a Car class with:
    1) Model, Year, IsRented.
    2) Methods RentCar() and ReturnCar().
    3) In Main(), create a fleet of 5 cars, let users rent and return cars.
    4) Prevent renting an already rented car.
*/

using System;

class Car
{
    string _carModel;
    string _carYear;
    bool _carIsRented;
    public string Model
    {
        get { return _carModel; }
    }
    public string Year
    {
        get { return _carYear; }
    }
    public bool IsRented
    {
        get { return _carIsRented;}
    }
    public Car(string Model, string Year)
    {
        _carModel = Model;
        _carYear = Year;
        _carIsRented = false;
    }
    public void RentCar()
    {
        if(_carIsRented == true)
        {
            Console.WriteLine($"{_carModel} {_carYear} is already rented.");
            return;
        }
        _carIsRented = true;
        Console.WriteLine($"You rented the {_carModel} {_carYear} succesfully.");
    }
    public void ReturnCar()
    {
        if (_carIsRented == false)
        {
            Console.WriteLine($"You didn't rent {_carModel} {_carYear} from us. ");
            return;
        }
        _carIsRented = false;
        Console.WriteLine($"You returned {_carModel} {_carYear} succesfully.");
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        Car[] carPark = new Car[5];
        for (int i=20; i < 25; ++i)
        {
            carPark[i-20] = new Car("Tesla", $"20{i}");
        }
        Console.WriteLine("Welcome to our car park!");
        while (true)
        {
            Console.WriteLine("Our car list: ");
            for (int i=0; i < 5; ++i)
            {
                if (carPark[i].IsRented == false)
                {
                    Console.WriteLine($"{i+1}. {carPark[i].Model} {carPark[i].Year} is available.");
                    continue;
                }
                Console.WriteLine($"{i+1}. {carPark[i].Model} {carPark[i].Year} is not available.");
            }
            Label:
            Console.Write("You want to rent or return a car? Type {Rent/Return} : ");
            string? userAnswer = Console.ReadLine();
            if (userAnswer!.ToLower() == "rent")
            {
            Console.Write("What car do you want to rent? Press (1-5) : ");
            int userAnswer2 = Convert.ToInt32(Console.ReadLine());
            if (userAnswer2 <= 5 & userAnswer2 >= 1)
                {
                    carPark[userAnswer2-1].RentCar();
                }
                else
                {
                    Console.WriteLine("Invalid answer! Try again.");
                    goto Label;
                }
            }
            else if (userAnswer!.ToLower() == "return")
            {
                Console.Write("What car do you want to return? Press (1-5) : ");
                int userAnswer2 = Convert.ToInt32(Console.ReadLine());
                if (userAnswer2 <= 5 & userAnswer2 >= 1)
                {
                    carPark[userAnswer2-1].ReturnCar();
                }
                else
                {
                    Console.WriteLine("Invalid answer! Try again.");
                    goto Label;
                }
            }
            else
            {
                Console.WriteLine("Invalid answer! Try again.");
                goto Label;
            }
            Label2:
            Console.Write("Do you want to rent or return another one? Press {y/n} : ");
            userAnswer = Console.ReadLine();
            if (userAnswer!.ToLower() == "y")
            {
                continue;
            }
            else if (userAnswer.ToLower() == "n")
            {
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