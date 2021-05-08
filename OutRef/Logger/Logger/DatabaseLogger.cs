using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Logger
{
    class DatabaseLogger : BaseLogger
    {
        public override void Log(string text)
        {
            Console.WriteLine($"Database result is: {text}");
        }
    }
}
