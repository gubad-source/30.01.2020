using System;

namespace Delegation
{
    class Program
    {
        static void Main(string[] args)
        {
            Action Test = Print;
            Test += Print;
            Test += Print;
            Test.Invoke();

            Action<int> TestInt = PrintInt;
            TestInt.Invoke(3);

            
        }


        public static void Print()
        {
            Console.WriteLine("Random text");
        }
        public static void PrintInt(int a)
        {
            Console.WriteLine(a*a);
        }
    }
}
