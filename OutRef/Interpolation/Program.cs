using System;

namespace Interpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            int b = 122;
            string currency = "$";
            //Console.WriteLine("{0}{2},{1}{2}",a,b,currency);
            string ret = string.Format("{0}{2},{1}{2}", b, a, currency);
            Console.WriteLine(ret);
        }
    }
}
