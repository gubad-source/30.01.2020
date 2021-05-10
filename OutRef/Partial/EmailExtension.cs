using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Partial
{
  static partial class Extension
    {
     static  public bool IsEmail(this string data)
        {
            if (Regex.IsMatch(data, "email"))
            {
                return true;
            }
            return false;
        }
    }
}
