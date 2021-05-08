using System;
using System.Globalization;
using System.Text;
using System.Threading;

namespace OutRef
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal animal1 = new Animal(20);
            //Animal animal2 = new Animal(30);
            //Console.WriteLine(animal1._age+ " "+animal2._age);

            //Anonymous class//
            //var student = new
            //{
            //    Id = 1,
            //    Name = "Gubad",
            //    Surname = "Mustafayev",
            //    Address = new
            //    {
            //        District = "masalli",
            //        City = "baki"
            //    }
            //};
            //Animal animal = new Animal(23);
            //animal.Class = "Seal";
            //Console.WriteLine(animal.Age);
            //Console.WriteLine(animal.Class);
            //animal.Mymethod();
            //string number = "123";
            //int value=20;
            //bool isReady = TryParsing(number, ref value);
            //if (isReady == true)
            //{
            //    Console.WriteLine("dfdfdfdf");
            //    value = value * value;
            //    Console.WriteLine(value);
            //}
            //else
            //{
            //    Console.WriteLine("yyyyyyyyyyyyyyyyyy");
            //}
            //     int a = 23;
            //     int b = 45;
            //     int area=200;
            //    int x= Rectangle(a, b, ref area);
            //     Console.WriteLine(x);
            // }
            //public static int Rectangle(int a,int b,ref int area)
            // {
            //    return   a + b +area;
            // }


            //public static bool TryParsing(string number,ref int data)
            //{
            //    //data = default(int);

            //    try
            //    {
            //        int num = Convert.ToInt32(number);
            //        //data = num;
            //        return true;
            //    }
            //    catch
            //    {
            //        return false;
            //    }
            //}

            //static void Change(in int[] a)
            //{
            //    a = new int[2];
            //}
            // int Hesab = 5000;
            // int maximum = 2000;
            //L1: int num = Convert.ToInt32(Console.ReadLine());
            // if (num < maximum)
            // {
            //     Hesab = Hesab - num;
            //     maximum = maximum - num;
            //      Console.WriteLine(maximum);
            //     goto L1;
            // }
            // else
            // {
            //     Console.WriteLine("Limiti asir");
            // }
            //Console.Write("Enter a length: ");
            //int len=Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[len];
            //for(var i = 0; i < len; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int max = GetMax(arr);
            //Console.WriteLine(max);
            //int max = GetMax(12, 34, 56, 78);
            //Console.WriteLine(max);
            //int max = GetArr (1, 23, 45, 66, 78, 12);
            // Console.WriteLine(max);
            Animal animal = new Animal();
            string msg=animal.Sound();
            Console.WriteLine(msg);

            Dog dog = new Dog();
            string msg2=dog.Sound();
            Console.WriteLine(msg2);

            //Console.ForegroundColor = ConsoleColor.Green;
            //string subway = "Xalqlar Dostlugu                    ";
            //for (; ; )
            //{
            //    Console.Beep();
            //    Thread.Sleep(200);
            //    Console.Clear();
            //    Console.WriteLine(subway);
            //    subway = subway.Substring(1) + subway[0];
            //}


            ///////////////////////////////////String///////////////////////////////////////////////
            //string demo = "bulbul";
            //char[] arr = { 'a', 'b', 'c','d', 'd' };
            //demo.CopyTo(1, arr, 2, 3);
            //Console.WriteLine(arr);

            Console.OutputEncoding = Encoding.UTF8;
            CultureInfo ci = new CultureInfo("az-Latn-AZ");
            string school = "263 ,sayli, orta mekteb";
            string str = school.Substring(0, 9);
            Console.WriteLine(str);
            string str2 = school.Substring(0).ToUpper(ci);
            Console.WriteLine(str2);
            bool state = str2.Contains("263",StringComparison.OrdinalIgnoreCase);
            Console.WriteLine(state);
            Console.WriteLine(str2[1]);

           
            int index = str2.LastIndexOf("d");
            Console.WriteLine(index);

            string[] words = str2.Split(new char[] { ';', ',', ' '},StringSplitOptions.RemoveEmptyEntries);
            foreach(var item in words)
            {
                Console.WriteLine(item);
            }
            int index2 = str2.LastIndexOfAny(new[] { '1', 'a' });
            Console.WriteLine(index2);
        }
        //public static int GetMax(params int[]numbers)
        //{
        //    Array.Sort(numbers);
        //    return numbers[numbers.Length - 1];
        //}
       //public static int GetArr(params int[] arr)
       // {
       //     return arr[2];
       // }

       
       
    }
}
