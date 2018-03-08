using System;
using System.Linq;

namespace ConsoleNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            var alumno = new Alumno()
            {
                Nombre = "Roberto"
            };

            //nullreference exceptions
            //var nombreDelProfesor = alumno.Profesor.Nombre;
            //var numeroLibros = alumno.Libros.Count();
            var nombreDelProfesor = alumno.Profesor?.Nombre;
            var numeroLibros = alumno.Libros?.Count();

            int numeroLibros2= alumno.Libros?.Count() ?? 0;

        }
    }
}
