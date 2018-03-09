using System;

namespace ConsoleAppLogMetodos
{
    class Program
    {       
        static void Main(string[] args)
        {
            bool test = RunMethod(Method1);

        }

        public static int Method1(string input)
        {
            return 1;
        }

        public static int Method2(string input)
        {
            return 2;
        }


        public static bool RunMethod(Func<string, int> methodName)
        {
            int i = methodName("pepe");

            return true;
        }
    }
}
