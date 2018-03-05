using System;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message();
            message.Name = "Roberto";

            Message message1 = new Message();
            message1.Name = "Roberto";



            //string name1 = "ROBERTO";
            //string name2 = "ROBERTO";

            Console.WriteLine(message.GetHashCode());
            Console.WriteLine(message1.GetHashCode());
            Console.WriteLine(message.Equals(message1));

            Console.WriteLine(Object.ReferenceEquals(message,message1));


            Console.ReadLine();


        }
    }
}
