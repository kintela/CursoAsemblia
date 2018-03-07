using System;

namespace ConsoleTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write Time1:");
            Time time1 = Console.ReadLine();

            Console.WriteLine("Write Time2:");
            Time time2 = Console.ReadLine();

            var totalTime = time1 + time2;

            Console.WriteLine($"Total Minutes: {totalTime.TotalMinutes}");

            Console.WriteLine($"Total: {totalTime}");

            Console.WriteLine(time1 == time2);

            Console.ReadLine();

        }
        
    }
}
