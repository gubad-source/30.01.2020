using System;

namespace StatisticMethods
{
    class Program
    {
        //static int a;
        static int[] arr;
        static void Main(string[] args)
        {
            arr = new[] { 1, 2, 3 };
            Console.WriteLine("==================Step1======================");
            foreach(var item in arr)
            {
                Console.WriteLine(item); ;
            }
            Console.WriteLine("=============================================");

            Console.WriteLine("==================Step2======================");
            SqrArr(arr);
            Console.WriteLine("=============================================");

            Console.WriteLine("==================Step3======================");
            foreach (var item in arr)
            {
                Console.WriteLine(item); ;
            }
            Console.WriteLine("=============================================");
            //AddNumber(a);
            //a = 19;



        }
        //static void AddNumber(int a)
        //{
        //    a++;
        //    Console.WriteLine($"Result is {a}");
        //}

        static void SqrArr(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = arr[i] * arr[i];
            }
            foreach(int item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
