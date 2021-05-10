using System;
using System.Collections.Generic;
using System.Text;

namespace Logger2.Logger
{
    class ReptilianLogger : BaseLogger
    {
        public override void Log(string info)
        {
            Console.WriteLine($"Current Reptilian class is:  {info}");
        }
    }
}
