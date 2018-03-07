using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleGenerics
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new List<Person>
            {
                new Person(){
                    Id=1,
                    Name="Iñaki",
                    LastName="Elcoro-Uribe",
                    Age=18
                },
                new Person(){
                    Id=2,
                    Name="Roberto",
                    LastName="Quintela-Modia",
                    Age=18
                },
                new Person(){
                    Id=3,
                    Name="Ainara",
                    LastName="Riesco",
                    Age=18
                }
            };

            Person person = list[0];

            var repository = new Repository();

            var result = repository.Create<Person>();

           
        }
    }
}
