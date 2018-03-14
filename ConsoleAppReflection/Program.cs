using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleAppReflection
{
    class Program
    {
        static void Main(string[] args)
        {         
            var repository = new AlumnoRepository();

            repository.Select<Person>(new
            {
                Id = 1,
                LastName = "Quintela"
            });

            Console.ReadLine();

        }

       
    }
}
namespace System.Linq
{
    public static class Extensions
    {
        public static string StringJoin<T>(this IEnumerable<T> list)
        {
            return list.Aggregate(String.Empty, (current, next) => $"{current},{next}");

        }
    }


}
