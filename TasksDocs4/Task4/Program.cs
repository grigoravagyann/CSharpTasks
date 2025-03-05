/*
Task 4: Weather Forecast System
Task: Create a class WeatherReport with:
    1) Fields: temperature, humidity, and weatherCondition.
    2) In Main(), create an array of WeatherReport objects for different cities and display the reports.
*/

class WeatherReport
{
    string? _weatherTemperature;
    string? _weatherHumidity;
    string? _weatherCondition;
    public string WeatherTemperature
    {
        get => _weatherTemperature!;
    }
    public string WeatherHumidity
    {
        get => _weatherHumidity!;
    }
    public string weatherCondition
    {
        get => _weatherCondition!;
    }
    public WeatherReport() {}
    public WeatherReport(string weatherTemperature, string weatherHumidity, string weatherCondition)
    {
        this._weatherTemperature = weatherTemperature;
        this._weatherHumidity = weatherHumidity;
        this._weatherCondition = weatherCondition;
    }
    public void DisplayWeather()
    {
        Console.WriteLine($"Temperature: {_weatherTemperature}\nHumidity: {_weatherHumidity}\nCondition: {_weatherCondition}");
    }
    public static WeatherReport CreateReport()
    {
        Console.Write($"Enter temperature: ");
        string? weatherTemperature = Console.ReadLine();
        Console.Write($"Enter humidity: ");
        string? weatherHumidity = Console.ReadLine();
        Console.Write($"Enter condition: ");
        string? weatherCondition = Console.ReadLine();
        WeatherReport newWeatherReport = new WeatherReport(weatherTemperature!,weatherHumidity!,weatherCondition!);
        return newWeatherReport;
    }
}

class MainClass
{
    static void Main(string[] args)
    {
        Console.Write("How cities weather you want to add? : ");
        int citiesCount = Convert.ToInt32(Console.ReadLine());
        WeatherReport[] cities = new WeatherReport[citiesCount];
        for (int i = 0; i < citiesCount; ++i)
        {
            Console.WriteLine($"Enter information of city {i+1}:");
            cities[i] = WeatherReport.CreateReport();
        }
        for (int i=0; i < citiesCount; ++i)
        {
            Console.WriteLine($"Information about city {i+1}:");
            cities[i].DisplayWeather();
        }
    }
}