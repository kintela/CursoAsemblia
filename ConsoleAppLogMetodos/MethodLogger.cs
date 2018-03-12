using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleAppLogMetodos
{
    public class MethodLogger
    {
        //public void RunAndLog(Action<Person> method)
        //{
        //    Console.WriteLine("Calling to method");

        //    Console.WriteLine("Method called");
        //}

        //public void RunAndLog(Func<string, int, Person> method)
        //{
        //    Console.WriteLine("Calling to method");

        //    Console.WriteLine("Method called");
        //}

        //public void RunAndLog(Func<int, Person> method)
        //{
        //    Console.WriteLine("Calling to method");

        //    Console.WriteLine("Method called");
        //}

        //public void RunAndLog<T, TResult>(Func<T, TResult> method)
        //{
        //    Console.WriteLine("Calling to method");

        //    Console.WriteLine("Method called");
        //}

        //public void RunAndLog(Action method)
        //{
        //    Console.WriteLine("Calling to method");

        //    method();

        //    Console.WriteLine("Method called");
        //}

        //public TREsult RunAndLog<TREsult>(Func<TREsult> method)
        //{
        //    Console.WriteLine("Calling to method");

        //    var result = method();

        //    Console.WriteLine("Method called");

        //    return result;

        //}

        public void RunAndLog(Action method)
        {
            var parameters = method.Method.GetParameters().Select(p => p.Name);
            var parameterNames = String.Join(",", parameters);

            Console.WriteLine($"Calling to method {method.Method.Name}");

            Console.WriteLine(parameterNames);

            method();

            Console.WriteLine("Method called");
        }





    }
}
