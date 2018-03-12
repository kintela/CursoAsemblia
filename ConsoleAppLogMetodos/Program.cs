using System;

namespace ConsoleAppLogMetodos
{
    class Program
    {       

        

        static void Main4(string[] args)
        {
            var logger = new MethodLogger();
            var repository = new PersonRepository();

            logger.RunAndLog(()=>repository.Get("Quintela",10));


            //logger.RunAndLog(() => repository.GetById(10));

            //var person = logger.RunAndLog(()=>repository.GetById(10));

            //logger.RunAndLog((p)=>repository.Save(new Person()));


            //logger.RunAndLog((s,i)=>repository.Get("Quintela",10));




            //logger.RunAndLog(() => repository.GetById(10));



            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            var logger = new PropertyLogger();

            var person = new Person()
            {
                Name = "Roberto",
                lastName = "Quintela",
                Id = 10
            };

            logger.LogMethod(() => person.FullName("Roberto", "Quintela"));

            Console.ReadLine();


            logger.LogProperty(() => person.Name);
            logger.LogProperty(() => person.lastName);

            
        }

       
      

       


    }
}
