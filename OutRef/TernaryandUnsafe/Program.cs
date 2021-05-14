using System;

namespace TernaryandUnsafe
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int? a = null;
                int? b = null;
                int c = (a.HasValue ? a.Value : 3) + (b.HasValue ? b.Value : 2);

                int* z = &c;
                IntPtr p = (IntPtr)z;
                Console.WriteLine(p);
            }
        }
    }
}
