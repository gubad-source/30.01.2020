using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Logger
{
    class EmailLogger : BaseLogger
    {
        public override void Log(string text)
        {
           Console.WriteLine($"Email result is: {text}");
        }
    }
}
