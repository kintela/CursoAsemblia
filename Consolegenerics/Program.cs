using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleGenerics
{
    class Program
    {
        static void Main(string[] args)
        {

            //var list = new ArrayList()
            //{
            //    new Person(){
            //        Name="Iñaki",
            //        LastName="Elcoro-Uribe",
            //        Age=18
            //    },
            //    new Person(){
            //        Name="Roberto",
            //        LastName="Quintela-Modia",
            //        Age=18
            //    },
            //    new Person(){
            //        Name="Ainara",
            //        LastName="Riesco",
            //        Age=18
            //    },
            //    new Animal(){
            //        Alias="Cuky"
            //    }

            //};

            //Person persona =(Person) list[3];

            //foreach (Person person in list)
            //{
            //    Console.WriteLine(person.Name);
            //}

            //var repository = new Repository();

            //var result = repository.Add(new Person()
            //{
            //    Name = "Iñaki"
            //});

            //Person personAdded = (Person)result.Item;

            var list = new List<Person>
            {
                new Person(){
                    Name="Iñaki",
                    LastName="Elcoro-Uribe",
                    Age=18
                },
                new Person(){
                    Name="Roberto",
                    LastName="Quintela-Modia",
                    Age=18
                },
                new Person(){
                    Name="Ainara",
                    LastName="Riesco",
                    Age=18
                }
            };

            Person person = list[0];           

            var repository = new Repository();

            var result = repository.Add<Person>(person);

            var result2 = repository.Add(person);



        }
    }
}
