using System;

namespace ConsoleClases
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message1 = new Message("Roberto");

            Message message2 = new Message("Roberto");

            Console.WriteLine(message1.ToString());
            Console.WriteLine(message1.GetHashCode());
            Console.WriteLine(message2.GetHashCode());

            Console.WriteLine(message1.Equals(message2));

            Console.ReadLine();
        }
    }
}
