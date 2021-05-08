using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    abstract class Computer : ICalculator, IWebcam
    {
       public abstract void Laptopp();
       public abstract void Voosh();
       
        public void Calculate()
        {
            Console.WriteLine("Takes Calculation measures...");
        }

        public void SelfieCamera()
        {
            Console.WriteLine("Takes frontal view of user...");
        }
    }
}
