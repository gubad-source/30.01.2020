using System;
using System.Collections.Generic;
using System.Text;

namespace Logger2.Logger
{
    class AmphibianLogger : BaseLogger
    {
        public override void Log(string info)
        {
            Console.WriteLine($"Current Amphibian class is:  {info}");
        }
    }
}
