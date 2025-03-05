/*
Task 3: File Download Simulation
Task: Create a class FileDownload with:
    1) Constructor that prints "Download started".
    2) Add a destructor that prints "Download completed".
    3) In Main(), create an object inside a method and observe when the destructor is called.
*/

using System;

class FileDownload
{
    public FileDownload()
    {
        Console.WriteLine("Download started.");
    }
    ~FileDownload()
    {
        Console.WriteLine("Download completed.");
    }
}

class Program
{
    static void Main()
    {
        SimulateFileDownload();
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }

    static void SimulateFileDownload()
    {
        FileDownload file = new FileDownload();
    }
}
