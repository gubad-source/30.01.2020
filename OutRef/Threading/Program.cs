using System;
using System.Threading;

namespace Threading
{
    class Program
    {
        /// <summary>
        /// Qaydaya uygun yazilib ancaq nedense error verir
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Thread ThreadA = new Thread(PrintA);
            Thread ThreadB = new Thread(PrintB);

            ThreadA.Start();
            Thread.Sleep(300);
            ThreadB.Start();
        }
        private static void PrintA(object obj)
        {
            for (int i = 0; i < 30000; i++)
            {
                Console.Write("A");
            }
        }
        private static void PrintB(object obj)
        {
            for (int i = 0; i < 30000; i++)
            {
                Console.Write("B");
            }
        }
    }
}
