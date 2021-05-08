using System;
using System.Collections.Generic;
using System.Text;

namespace Logger.Logger
{
    class SmsLogger : BaseLogger
    {
        public override void Log(string text)
        {
            Console.WriteLine($"Sms result is: {text}");
        }
    }
}
