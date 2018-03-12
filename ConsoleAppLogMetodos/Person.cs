using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLogMetodos
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string lastName { get; set; }

        public void FullName(string name, string lastname)
        {
            this.Name = name;
            this.lastName = lastName;
        }
    }

}
