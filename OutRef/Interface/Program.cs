using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
         

            Computer computer = new Laptop();
            computer.Laptopp();
            computer.Calculate();
            //computer.Calculate();
            //computer.SelfieCamera();
        }
    }
}
