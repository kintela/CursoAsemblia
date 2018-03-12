using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Collections.Generic
{
    public class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public string LastName { get; set; }
    }

    public static class PersonExtension
    {
        public static string FullName(this Person person) => $"{person.Name} {person.LastName}";

        public static int OurCount<T>(this IEnumerable<T> collection) => collection.Count<T>();
    }

}
