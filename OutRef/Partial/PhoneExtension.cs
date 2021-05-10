using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Partial
{
    static partial class Extension
    {
     static public bool IsPhone(this string data)
        {
            if (Regex.IsMatch(data, "phone"))
            {
                return true;
            }
            return false;
        }
    }
}
