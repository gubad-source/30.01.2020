using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int num = a;
            string result = "";
            switch (num)
            {
                case 501:
                    {
                        result = $"{num} is the num";
                        break;
                    }
                case 212:
                    {
                        result = $"{num} is the result";
                        break;
                    }
                default:
                    result = $"{num} is not the number in database";
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
