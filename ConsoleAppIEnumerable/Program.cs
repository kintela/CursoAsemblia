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

            var myList = new List2();

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
