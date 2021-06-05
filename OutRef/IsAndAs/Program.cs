using System;

namespace IsAndAs
{
    class Program
    {
        static void Main(string[] args)
        {
            object a = 5;
            int? b = a as int?;
            //string b = a as string;

            if (b is int)
            {
                Console.WriteLine("it is integer");
            }else if(b is string)
            {
                Console.WriteLine("it is string");
            }
            else
            {
                Console.WriteLine("Null");
            }
        }
    }
}
