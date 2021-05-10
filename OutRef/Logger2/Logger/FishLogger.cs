using System;
using System.Collections.Generic;
using System.Text;

namespace Logger2.Logger
{
    class FishLogger : BaseLogger
    {
        public override void Log(string info)
        {
            Console.WriteLine($"Current Fish class is:  {info}");
        }
    }
}
