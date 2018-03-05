using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Time
    {
        private const int minutesInHours = 60;
        public int TotalMinutes { get; }

        public Time(string time)
        {
            string[] parts = time.Split(":");

            Int32.TryParse(parts[0], out var hours);
            Int32.TryParse(parts[1], out var minutes);

            TotalMinutes= hours * minutesInHours + minutes;
        }

        public Time(int totalMinutes)
        {
            TotalMinutes = totalMinutes;
        }
        public static Time operator +(Time x, Time y) => new Time(x.TotalMinutes + y.TotalMinutes);

        public static implicit operator Time(string input)=> new Time(input);

        public override string ToString()
        {
            int hours = TotalMinutes / minutesInHours;
            int minutes = TotalMinutes % minutesInHours;

            return $"{hours:00}:{minutes:00}";
        }

        public override bool Equals(object obj) => TotalMinutes == ((Time)obj).TotalMinutes;
        public override int GetHashCode() => TotalMinutes.GetHashCode();

        public static bool operator ==(Time x, Time y) => x.Equals(y);
        public static bool operator !=(Time x, Time y) => !x.Equals(y);
    }
}
