using System;
using System.Collections.Generic;
using System.Text;

namespace StaticConstructor
{
   static class Car
    {
        public static void Test(string info)
        {
            Console.WriteLine($"Result is: {info}");
        }
        static Car()
        {
            Console.WriteLine("Static Ctor invoked");
        }
    }
}
