using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleNullable
{
    public class Alumno
    {
        public string Nombre { get; set; }
        public Profesor Profesor { get; set; }

        public IEnumerable<Libro> Libros { get; set; }
    }

    public class Profesor
    {
        public string Nombre { get; set; }
    }

    public class Libro
    {
        public string Titulo { get; set; }
    }
}
