using System;
using System.Collections.Generic;
using System.Text;

namespace Generic
{
    class Test<T>
        where T:People,new()
    {
      public void Print(T value)
        {
            Console.WriteLine(value);
        }
        public void Print2(T value)
        {
            Console.WriteLine(value);
        }
    }
}
