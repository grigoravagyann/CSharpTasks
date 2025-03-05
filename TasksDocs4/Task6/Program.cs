/*
Task 6: Movie Rating System
Task: Create a class Movie with:
    1) Private field _rating.
    2) Add a property Rating that: Allows setting a value between 1 and 5.
    4) Prints a warning if an invalid value is entered.
    4) In Main(), test the property with valid and invalid values.
*/

class Movie
{
    string? _movieRating;
    public string movieRating
    {
        get => _movieRating!;
    }
    public Movie(){}
    public void SetRating()
    {
        Label:
        Console.WriteLine("Rate movie from 1 to 5 : ");
        int userRate = Convert.ToInt32(Console.ReadLine());
        if (userRate >= 1  && userRate <= 5)
        {
            Console.WriteLine($"You rated {userRate} to movie.");
            _movieRating = Convert.ToString(userRate);
            return;
        }
        Console.WriteLine("Invalid rate! Try again.");
        goto Label;
    }
    public void ShowRate()
    {
        Console.WriteLine($"Movie rate is {_movieRating}.");
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        Movie newMovie = new Movie();
        newMovie.SetRating();
        newMovie.ShowRate();
    }
}