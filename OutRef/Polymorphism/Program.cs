using System;
using System.Threading;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.ForegroundColor = ConsoleColor.Red;
            string subway = "Bakmil  ";
            for (; ; )
            {
                Console.Beep();
                Console.Clear();
                Thread.Sleep(200);
                Console.WriteLine(subway);
                subway = subway.Substring(1) + subway[0];
            
            }

            return;

            Bird bird = new Bird("Birdy", "xfdfdf");
            bird.Eat();
            string msg = bird.Class;
            string msg2 = bird.Family;
            Console.WriteLine(msg2);
            Vertebrate vertebrate = new Vertebrate();
            int x = vertebrate.Add(2, 3, 5, 10);
            Console.WriteLine(x);
            int y = GetArr("heyva", "alma", "nar", "heyva");
            Console.WriteLine(y);
        }
        public static int GetArr(string founded, params string[]fruits)
        {
            int index = -1;
            for(int i = 0; i < fruits.Length; i++)
            {
                if (fruits[i] == founded)
                {
                    index = i;
                }
            }
            return index;
        }
    }
}
