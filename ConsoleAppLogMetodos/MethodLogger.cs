using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppLogMetodos
{
    public class MethodLogger
    {

        public void RunAndLog(Action method)
        {
            Console.WriteLine("Calling to method");

            method();

            Console.WriteLine("Method called");
        }

        //public void RunAndLog(Action<Person> method)
        //{
        //    Console.WriteLine("Calling to method");

        //    Console.WriteLine("Method called");
        //}

        //public void RunAndLog(Func<string,int,Person> method)
        //{
        //    Console.WriteLine("Calling to method");

        //    Console.WriteLine("Method called");
        //}

        //public void RunAndLog <T,TResult>(Func<T, TResult> method)
        //{
        //    Console.WriteLine("Calling to method");

        //    Console.WriteLine("Method called");
        //}

    }
}
