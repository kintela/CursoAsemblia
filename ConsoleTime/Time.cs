using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTime
{
    public class Time
    {
        private string time;
        private int totalMinutes;

        public int TotalMinutes
        {
            get
            {
                string[] parts = time.Split(":");

                if (!Int32.TryParse(parts[0], out var hours))
                {
                    totalMinutes = 0;
                }


                if (!Int32.TryParse(parts[1], out var minutes))
                {
                    totalMinutes = 0;
                }

                totalMinutes = (hours * 60) + minutes;

                return totalMinutes;
            }

             set => totalMinutes=value;
        }

        public Time(string time)
        {
            this.time = time;  
        }

        public Time(int totalMinutes)
        {
            TotalMinutes = totalMinutes;
        }

        public static implicit operator Time(string input)=>new Time(input);

        public override string ToString()
        {
            int hours = TotalMinutes / 60;
            int minutes = TotalMinutes % 60;

            return $"{hours:00}:{minutes:00}";            
        }

        public static Time operator +(Time x, Time y) => new Time(x.TotalMinutes + y.TotalMinutes);

        public override int GetHashCode() => TotalMinutes.GetHashCode();
        public override bool Equals(object obj) => TotalMinutes == ((Time)obj).TotalMinutes;
       


        public static bool operator ==(Time x, Time y) => x.Equals(y);
        public static bool operator !=(Time x, Time y) => !x.Equals(y);
    }
}
