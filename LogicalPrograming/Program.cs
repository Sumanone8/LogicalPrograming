using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Stopwatch Program");
        Console.WriteLine("------------------");
        Console.WriteLine("Press any key to start the stopwatch...");
        Console.ReadKey();

        DateTime startTime = DateTime.Now;

        Console.WriteLine("Stopwatch started. Press any key to stop...");
        Console.ReadKey();

        DateTime endTime = DateTime.Now;

        TimeSpan elapsedTime = endTime - startTime;

        Console.WriteLine($"Elapsed time: {elapsedTime.TotalSeconds} seconds");
    }
}