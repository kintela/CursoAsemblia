using System;
using System.Collections;
using System.Text;

namespace ConsoleGenerics
{
    public class Person:IIdentity
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }
        public int Id { get ; set ; }
    }
}
