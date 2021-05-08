using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
   public  class Vertebrate
    {
        public virtual void Eat()
        {
            Console.WriteLine("Can eat food");
        }
        public int Add(int a,int b)
        {
            return a + b;
        }
        public int Add(int a, int b,int c)
        {
            int cem = Add(a, b);
            cem = cem + c;
            return cem;
        }
        public int Add(int a,int b,int c,int d)
        {
            int cem = Add(a, b, c);
            cem = cem + d;
            return cem;
        }
    }
}
