using AccessModifiers;
using System;


namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            //SmsLog("test");
            //DatabaseLog("test");
            //EmailLog("test");

            WorkSpace workSpace = new WorkSpace();
            workSpace.TestProccess();

            Movies movies = new Movies();

            AccessModifiers2 accessModifiers = new AccessModifiers2();
            accessModifiers.GetYear();
           
        }

     
    }
}
