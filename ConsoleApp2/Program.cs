using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write Time 1");
            //string timeInput1 = Console.ReadLine();
            Time time1 = Console.ReadLine();


            Console.WriteLine("Write Time 2");
            //string timeInput2 = Console.ReadLine();
            Time time2 = Console.ReadLine();

            //var time1 = new Time(timeInput1);
            //var time2 = new Time(timeInput2);

            var totalTime = time1 + time2;

            Console.WriteLine($"Total Minutes: {totalTime.TotalMinutes}");
            Console.WriteLine($"Total Hours: {totalTime}");
            //Console.WriteLine(time1.Equals(time2));
            Console.WriteLine(time1 == time2);

            Console.ReadLine();

            //int minutes1 = GetMinutes(time1);

            //int minutes2 = GetMinutes(time2);



            //int totalMinutes = minutes1 + minutes2;



            //Console.WriteLine("Total Minutes " + totalMinutes);



            //int hours = totalMinutes / 60;

            //int minutes = totalMinutes % 60;



            //Console.WriteLine("Total:" + String.Format("{0:00}", hours) + ":" + String.Format("{0:00}", minutes));
            //Console.WriteLine($"Total:{ hours:0:00},{minutes:0:00}");

            //Console.WriteLine("Press any key to exit");

            //Console.ReadLine();

        }
        private static int GetMinutes(string time1)

        {

            string[] parts = time1.Split(":");



            if (!Int32.TryParse(parts[0], out var hours))

                return 0;



            if (!Int32.TryParse(parts[1], out var minutes))

                return 0;



            return (hours * 60) + minutes;

        }
    }
}
