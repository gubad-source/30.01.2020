using System;

namespace ReadonlyAndConst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Phone phone = new Phone(14);
            Console.WriteLine(phone._price);
            phone.Comp();
           


            //string[] animals = { "dog", "donkey", "hippo", "parrot" };
            //string result=Arr(animals,"hippo");
            //Console.WriteLine(result);
        }
       //public static string Arr(string[]arr,string found)
       // {
       //     for(int i = 0; i < arr.Length; i++)
       //     {
       //         if (arr[i] == found)
       //         {
       //            found= arr[i].ToUpper();
       //         }
          
       //     }
       //     return found;
       // }
    }
}
