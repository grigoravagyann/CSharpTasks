/*
Task 4: Convert Temperature
Task: Write a program for temperature conversion:
    1) Write a method that converts Celsius to Fahrenheit and Kelvin.
    2) Use ref and out in method parameters.
    3) Call it with a user-provided Celsius value.
*/

class MainClass
{
    static void Main(string[] args)
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToInt32(Console.ReadLine());
        double fahrenheit = 0;
        double kelvin = 0;
        ConvertTemperature(ref celsius,out fahrenheit,out kelvin);
        Console.WriteLine($"Fahrenheit: {fahrenheit}, Kelvin: {kelvin}");
    }
    
    static void ConvertTemperature(ref double celsius,out double fahrenheit, out double kelvin)
    {
        fahrenheit = (celsius*9/5) + 32 ;
        kelvin = celsius + 273.15 ;
    }
}