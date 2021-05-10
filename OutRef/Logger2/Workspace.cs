using Logger2.Logger;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger2
{
    class Workspace
    {
        BaseLogger logger = new AmphibianLogger();

       public void SendLog(string info)
        {
            logger.Log(info);
        }
        public void Test()
        {
            try
            {
                int a = 1 / Convert.ToInt32("0");
            }catch(Exception e)
            {
                SendLog(e.Message);
            }
        }
    }
}
