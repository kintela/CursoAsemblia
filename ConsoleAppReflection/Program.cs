using System;
using System.Reflection;
using System.Linq;

namespace ConsoleAppReflection
{
    class Program
    {
        static void Main(string[] args)
        {            
            
            var repository = new AlumnoRepository();

            repository.Select<Alumno>();
            repository.Select<Person>();

            Console.ReadLine();

        }
    }
}
