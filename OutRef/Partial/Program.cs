using System;

namespace Partial
{
    class Program
    {
        static void Main(string[] args)
        {
            string info = "email";
            if (info.IsPhone())
            {
                Console.WriteLine("You have entered with phone");
            }
            else if (info.IsEmail())
            {
                Console.WriteLine("You have entered with email");
            }
            else
            {
                Console.WriteLine("You have entered with another account");
            }
        }
    }
}
