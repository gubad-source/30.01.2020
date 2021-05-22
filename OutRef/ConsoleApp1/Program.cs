using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int X = (x == 3 ? x:x=4);
            Console.WriteLine(X);
            return;
            Cartoon cartoon = new Cartoon("Hazbin Hotel",Color.All);
            Console.WriteLine(cartoon);
            if (cartoon.color.HasFlag(Color.Red))
            {
                Console.WriteLine($"It is {Color.Red}");
            }
            if (cartoon.color.HasFlag(Color.Yellow))
            {
                Console.WriteLine($"It is {Color.Yellow}");
            }
            if (cartoon.color.HasFlag(Color.Black))
            {
                Console.WriteLine($"It is {Color.Black}");
            }
            if (cartoon.color.HasFlag(Color.All))
            {
                Console.WriteLine($"It is {Color.All}");
            }
            if (cartoon.color.HasFlag(Color.All2))
            {
                Console.WriteLine($"It is {Color.All2}");
            }
            if (cartoon.color.HasFlag(Color.White))
            {
                Console.WriteLine($"It is {Color.White}");
            }
            return;
            unsafe
            {
                int? a=null;
                int? b=null;
                int c = (a.HasValue ? a.Value : 2) + (b.HasValue ? b.Value : 7);
                Console.WriteLine(c);
                int* z = &c;
                IntPtr p = (IntPtr)z;
                Console.WriteLine(p);
            }
            int num = 3;
            string result = "";
            switch (num)
            {
                case 1:
                    {
                        result = "It is 1";
                        break;
                    }
                case 2:
                    {
                        result = "It is 2";
                        break;
                    }
                case 3:
                    {
                        result = "It is 3";
                        break;
                    }
                default:
                    result = "It is not possible";
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
