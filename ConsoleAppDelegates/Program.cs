using System;

namespace ConsoleAppDelegates
{
    class Program
    {

        static void Main(string[] args)
        {
            var person = new Person()
            {
                Name = "Pepe",
                Age = 49
            };

            var animal = new Animal()
            {
                Alias = "Lagun",
                Size = 49
            };

            Print(animal,a=>a.Alias);
            Print(person, p=>p.Name);

            Console.ReadLine();

        }

        public static void Print<T,TResult>(T entity,Func<T,TResult> select) => Console.WriteLine(select(entity));


    }
}
