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
