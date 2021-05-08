using System;
using System.Collections.Generic;
using System.Text;

namespace OutRef
{
    public class Dog:Animal
    {
        public override string Sound()
        {
            Console.WriteLine("bla bla");
            return base.Sound();
        }
    }
}
