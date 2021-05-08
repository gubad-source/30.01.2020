using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
     class Laptop : Computer
    {
       public override void Laptopp()
        {
            Console.WriteLine("it is portible than computer");
        }

        public override void Voosh()
        {
            throw new NotImplementedException();
        }
    }
}
