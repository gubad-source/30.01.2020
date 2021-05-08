using System;
using System.Collections.Generic;
using System.Text;

namespace OutRef
{
   public class Calculator
    {
      public static int Add(int a,int b)
        {
            return a + b;
        }
        public static int Add(int a, int b,int c)
        {
            int cem = Add(a, b);
            cem = Add(cem, c);
            return cem;
        }
        public static int Add(int a, int b, int c,int d)
        {
            int cem = Add(a, b, c);
            cem = Add(cem, d);
            return cem;
        }
    }
}
