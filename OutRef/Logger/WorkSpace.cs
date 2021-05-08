using Logger.Logger;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logger
{
    class WorkSpace
    {
        BaseLogger logger = new SmsLogger();

        private void SendToLog(string message)
        {
            logger.Log(message);
        }

        public void TestProccess()
        {
            try
            {
                int a = 1 / Convert.ToInt32("0");
            }
            catch (Exception e)
            {
                SendToLog(e.Message);
            }
        }



        public void ProductionProccess()
        {
            try
            {
                throw new Exception("hmmmmmmmmmmmmmmmmmmmmmmmm");
            }
            catch (Exception e)
            {
                SendToLog(e.Message);
            }
        }
    }
}
