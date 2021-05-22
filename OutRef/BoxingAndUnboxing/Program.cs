using System;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            object b = a;
            //int unboxedA = (int)b;
            //int unboxedA = Convert.ToInt32(b);
            //int unboxedA = int.Parse(b);
            //Console.WriteLine(unboxedA);

            string test = "23";

            int zz;
            if(int.TryParse((test),out zz))
            {
                Console.WriteLine($"Answer is: {test}");
            }
            else
            {
                Console.WriteLine("Can not convert");
            }
        }
    }
}
