/*
Task 3:  Computed Property with String Formatting
Task: Create a TimePeriod class with:
    1) A property TotalSeconds (int).
    2) A computed property FormattedTime that returns "HH:mm:ss" format.
*/

class TimePeriod
{
    int _timeTotalSeconds;
    string? _timeFormattedTime;
    public int TotalSeconds
    {
        get => _timeTotalSeconds;
        set => _timeTotalSeconds = value;
    }
    public string FormattedTime
    {
        get => ($"{TotalSeconds/3600}:{TotalSeconds/60-TotalSeconds/60*TotalSeconds/3600}:{TotalSeconds-TotalSeconds/60}");
    }

}