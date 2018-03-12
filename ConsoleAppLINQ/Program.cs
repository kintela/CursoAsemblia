using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            person.FullName();

            var coleccion = new List<int> { 1, 2, 3 };

            coleccion.OurCount();

            
        }
    }
}
