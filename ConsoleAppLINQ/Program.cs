using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLINQ
{
    class Program
    {
        static void Main2(string[] args)
        {
            var person = new Person();

            person.FullName();

            var coleccion = new List<int> { 1, 2, 3 };

            coleccion.OurCount();

            
        }

       


        static void Main(string[] args)
        {

            var alumnos2 = new List<Alumno>()
            {
                new Alumno(){ Age=21, Name="Iñaki", LastName="Elcoro"},
                new Alumno(){ Age=23, Name="Robeto", LastName="Quintela"},
                new Alumno(){ Age=18, Name="Ainara", LastName="Riesco"}
            };


            Console.WriteLine(alumnos2.StringJoin());

            Console.ReadLine();

            //var list = new List<string>() { "1", "2", "3", "4" };

            //Console.WriteLine(list.StringJoin());

            //Console.ReadLine();

            //var alumnos = new List<Alumno>()
            //{
            //    new Alumno(){ Age=21, Name="Iñaki", LastName="Elcoro"},
            //    new Alumno(){ Age=23, Name="Robeto", LastName="Quintela"},
            //    new Alumno(){ Age=18, Name="Ainara", LastName="Riesco"}
            //};



            //var filtrados = alumnos.Where(a => a.Age < 23).ToList();

            //var concatenados = alumnos.Concat(alumnos2).ToList();

            //Console.WriteLine(String.Join(",", concatenados.Select(a => a.Name)));

            //var alumnosViewmodel= alumnos.Select(a => new AlumnoViewModel()
            //{
            //    Age = a.Age,
            //    FullName = a.Name + ", " + a.LastName
            //});


            //var ordenados=alumnosViewmodel.Where(a=>a.Age<23).OrderBy(a => a.Age).ToList();

            //var sumaEdades = ordenados.Sum(a => a.Age);


            //Console.ReadLine();

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