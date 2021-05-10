using System;
using System.Collections.Generic;
using System.Text;

namespace Extension
{
    static class PrivateMethods
    {
       public static string Reverse(this string value)
        {
            string emptyValue = "";
            for(int i = value.Length - 1; i >= 0; i--)
            {
                emptyValue += value[i];
            }
            return emptyValue.ToUpper();
        }
      
    }
}
