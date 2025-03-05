/*
Task 9: Time Converter
Task: Write a program that converts seconds to time:
    1) Write a method that converts totalSeconds into hours, minutes, and seconds.
    2) Use ref and out in method parameters.
    3) Call it with a user-provided totalSeconds.
*/

class MainClass
{
    static void Main(string[] args)
    {
        Console.Write("Enter time in seconds: ");
        int totalSeconds = Convert.ToInt32(Console.ReadLine());
        int hours = 0;
        int minutes = 0;
        TimeConverter(totalSeconds, ref hours, out minutes);
        Console.WriteLine($"Hours: {hours}, Minutes: {minutes}");
    }

    static void TimeConverter(int totalSeconds, ref int hours, out int minutes)
    {
        hours = totalSeconds/3600;
        minutes = totalSeconds/60;
    }
}