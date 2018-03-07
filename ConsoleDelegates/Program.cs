using System;

namespace ConsoleDelegates
{
    class Program
    {
        public delegate void Print(int value);
        static void Main2(string[] args)
        {
            Print printDelegate = PrintNumber;

            printDelegate += PrintMoney;

            printDelegate(1000);


            Console.ReadLine();

        }

        static void Main(string[] args)
        {
            Func<int, int, int> add = Sum;

            int result = add(9, 5);

            Console.WriteLine(result);


            Console.ReadLine();

        }
        public static void PrintNumber(int num) => Console.WriteLine("Number: {0,-12:N0}", num);

        public static void PrintMoney(int money) => Console.WriteLine("Money: {0:C}", money);

        public static void PrintHelper(Print delegateFunc, int numToPrint) => delegateFunc(numToPrint);

        public static int Sum(int x, int y) => x + y;

    }
}
