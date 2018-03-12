using System;

namespace ConsoleAppLogMetodos
{
    class Program
    {       

        static void Main(string[] args)
        {
            RunMethod(Method1);
            RunMethod(Method2);

            RunMethod2(Method3);

            RunMethod3(5, Method5);
            RunMethod3("pepe", Method6);
            RunMethod4("pepe", Method7);

            Console.ReadLine();
        }

        public static int Method1()
        {
            return 1;
        }

        public static int Method2()
        {
            return 2;
        }

        public static int Method3(string input)
        {
            return 1;
        }

        public static int Method4(string input)
        {
            return 2;
        }

        public static string Method5(int input)
        {
            return "2";
        }

        public static bool Method6(string input)
        {
            return true;
        }

        public static void Method7(string input)
        {
            Console.WriteLine("No devuelvo nada");
        }

        //Métodos sin parametros y que devuelven int
        public static void RunMethod(Func<int> method)
        {
            Console.WriteLine($"Start Method {method}");
            int i = method();
            Console.WriteLine($"End Method { method}");            

        }
        //Métodos con un parametro int y que devuelven string
        public static void RunMethod2(Func<string,int> method)
        {
            Console.WriteLine($"Start Method {method.Method.Name}");
            int i = method("text");
            Console.WriteLine($"End Method { method}");

        }

        //Métodos con un parametro de cualquier tipo y que devuelve cualquier tipo
        public static void RunMethod3<T,TResult>(T inputParameter, Func<T, TResult> method)
        {
            Console.WriteLine($"Start Method {method.Method.Name}");
            TResult result = method(inputParameter);
            Console.WriteLine($"End Method { method}");

        }

        //Métodos con un parametro de cualquier tipo y que devuelve cualquier tipo
        public static void RunMethod4<T>(T inputParameter, Func<T> method)
        {
            Console.WriteLine($"Start Method {method.Method.Name}");
            method(inputParameter);
            Console.WriteLine($"End Method { method}");

        }

    }
}
