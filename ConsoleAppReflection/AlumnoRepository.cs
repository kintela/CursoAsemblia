using System;
using System.Linq;
using System.Reflection;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

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

        public void Select<T>(object whereParts)
        {
            var tipo = typeof(T);

            var propiedades = tipo.GetProperties();

            var tablename = tipo.GetCustomAttribute<TableAttribute>();

            TypeInfo tipoWhere = whereParts.GetType().GetTypeInfo();

            var propiedadesWhere = tipoWhere.GetProperties();

            var where = " where " + String.Join(" and ", propiedadesWhere.Select(p => p.PropertyType==typeof(String)? $"{p.Name}='{p.GetValue(whereParts)}'" : $" {p.Name}={p.GetValue(whereParts)}"));

            Console.WriteLine($"Select {string.Join(",", propiedades.Select(p => p.Name))} from {tablename.Name} {where}");
           

        }

    }
}
