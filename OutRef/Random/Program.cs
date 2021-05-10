using System;

namespace Random1
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[len];
            Random rnd = new Random();
            int a;
            for(int i = 0; i < arr.Length; i++)
            {
              L1:  a = rnd.Next(1, 30);
                if (Array.IndexOf(arr, a)==-1)
                {
                    arr[i] = a;
                }
                else
                {
                    goto L1;
                }
               
            }
            foreach(var item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
