using System;
using System.Collections.Generic;

namespace ConsoleAppIEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            //var myList = new List();

            //foreach (var item in myList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadLine();

            Party party = new Party();
            party.AddGuest(new Guest() { Age = 25, Name = "John" });
            party.AddGuest(new Guest() { Age = 24, Name = "Barbara" });
            party.AddGuest(new Guest() { Age = 24, Name = "Phil" });
            party.AddGuest(new Guest() { Age = 23, Name = "Fred" });
            party.AddGuest(new Guest() { Age = 26, Name = "Hannah" });
            party.AddGuest(new Guest() { Age = 27, Name = "Cindy" });

            foreach (Guest guest in party)
            {
                Console.WriteLine(guest.Name);
            }


            Console.ReadLine();
        }
    }
}
