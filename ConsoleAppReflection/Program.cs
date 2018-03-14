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

        static void Main3(string[] args)
        {
            var alumno = new Alumno()
            {
                Id=1,
                Name="Roberto"
            };

            var person = new Person()
            {
                Id = 1,
                LastName = "Quintela"
            };
            var repository = new AlumnoRepository();

            repository.Select(alumno);
            repository.Select(person);

            Console.ReadLine();

        }
    }
}
