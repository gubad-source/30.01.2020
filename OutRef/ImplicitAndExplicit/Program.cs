using System;

namespace ImplicitAndExplicit
{
    class Program
    {
        static void Main(string[] args)
        {
            ///////explicit=boyukden kiciye ve data itirilir
            decimal num1 = 20.1M;
            int num2 = (int)num1;
            Console.WriteLine(num2);
            //////////implicit=kicikden boyuye ve data itirilmir
            byte num3 = 127;
            decimal num4 =(decimal) num3;
            Console.WriteLine(num4);
            //////////////////////////////////////////////
            decimal value = 23.6M;
            Converter price = value;
            Console.WriteLine(price);
        }
    }
}
