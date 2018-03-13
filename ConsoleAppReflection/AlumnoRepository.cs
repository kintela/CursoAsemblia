using System;
using System.Linq;
using System.Reflection;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConsoleAppReflection
{
    public class AlumnoRepository
    {
        public void Select(Alumno alumno)
        {
            TypeInfo tipo = alumno.GetType().GetTypeInfo();

            var propiedades = tipo.GetProperties();

            var tablename = tipo.GetCustomAttribute<TableAttribute>();

            Console.WriteLine($"Select {string.Join(",", propiedades.Select(p => p.Name))} from {tablename.Name}");

        }

        public void Select(object objeto)
        {
            TypeInfo tipo = objeto.GetType().GetTypeInfo();

            var propiedades = tipo.GetProperties();

            var tablename = tipo.GetCustomAttribute<TableAttribute>();

            Console.WriteLine($"Select {string.Join(",", propiedades.Select(p => p.Name))} from {tablename.Name}");

        }

        public void Select(TypeInfo tipo)
        {

            var propiedades = tipo.GetProperties();

            var tablename = tipo.GetCustomAttribute<TableAttribute>();

            Console.WriteLine($"Select {string.Join(",", propiedades.Select(p => p.Name))} from {tablename.Name}");

        }

        public void Select<T>()
        {
            var tipo = typeof(T);
            
            var propiedades = tipo.GetProperties();

            var tablename = tipo.GetCustomAttribute<TableAttribute>();

            Console.WriteLine($"Select {string.Join(",", propiedades.Select(p => p.Name))} from {tablename.Name}");

        }

    }
}
