using System;

namespace ConsoleDelegates
{
    class Program
    {
        //public delegate void Print(int value);
        static void Main2(string[] args)
        {
            //Print printDelegate = PrintNumber;

            //printDelegate += PrintMoney;

            //printDelegate(1000);


            //Console.ReadLine();

        }

        static void Main3(string[] args)
        {
            //Func<int, int, int> add = Sum;

            //int result = add(9, 5);

            //Console.WriteLine(result);


            //Console.ReadLine();

        }

        //public delegate bool PersonCriteria(Person person);
        static void Main(string[] args)
        {
            int minAge = 21;

            var persona = new Person()
            {
                Name="Roberto"
            };            

            bool isKnown = IsKnownPeson(IsRoberto,persona);

            bool isKnown2 = IsKnownPeson(delegate(Person person) {
                return person.Age > 21;
            },persona);

            bool isKnown3 = IsKnownPeson(p => p.Age > 21,persona);

            bool isKnown4 = IsKnownPeson(p => p.Age > minAge, persona);

            bool isKnown5 = IsKnownPeson(p=>IsRoberto2(p,minAge),persona);

        }

        public static bool IsKnownPeson(Func<Person,bool> criteria, Person person)
        {
            if (person == null)
            {
                throw new ArgumentNullException(nameof(person));
            }
            return criteria(person);
        }

        //public delegate T SelectProperty<T>(Person person);

        static void Main6(string[] args)
        {
            //var person = new Person()
            //{
            //    Name = "Roberto",
            //    LastName = "Quintela Modia",
            //    Age = 49
            //};

            //Print(p=>p.Name,person);
            //Print(p => p.LastName, person);
            //Print(p => p.Age, person);

            //Console.ReadLine();

        }

        //public delegate TResult SelectProperty<T,TResult>(T entity);
        static void Main4(string[] args)
        {
            var person = new Person()
            {
                Name = "Roberto",
                LastName = "Quintela Modia",
                Age = 49
            };

            var animal = new Animal()
            {
                Alias = "Lagun",
                Size = 10.2m
            };


            Print<Animal,string>(animal,a=>a.Alias);

            Print(animal, a => a.Alias);



            Console.ReadLine();

        }
        public static void Print<T,TResult>(T entity,Func<T,TResult> select)
        {
            Console.WriteLine(select(entity));
        }



        

        public static bool IsRoberto(Person person)
        {
            return person.Name == "Roberto";            
        }

        public static bool IsRoberto2(Person person, int minAge)
        {
            return person.Name == "Roberto" && person.Age>minAge;
        }


        //public static void PrintNumber(int num) => Console.WriteLine("Number: {0,-12:N0}", num);

        //public static void PrintMoney(int money) => Console.WriteLine("Money: {0:C}", money);

        //public static void PrintHelper(Print delegateFunc, int numToPrint) => delegateFunc(numToPrint);

        //public static int Sum(int x, int y) => x + y;

    }
}
