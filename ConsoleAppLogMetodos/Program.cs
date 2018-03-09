using System;

namespace ConsoleAppLogMetodos
{
    class Program
    {       
        static void Main(string[] args)
        {
            RunMethod(Method1);
            RunMethod(Method2);

            Console.ReadLine();
        }

        public static int Method1(string input)
        {
            return 1;
        }

        public static int Method2(string input)
        {
            return 2;
        }


        public static void RunMethod(Func<string, int> methodName)
        {
            Console.WriteLine($"Start Method {methodName}");
            int i = methodName("text");
            Console.WriteLine($"End Method { methodName}");            

        }
    }
}
