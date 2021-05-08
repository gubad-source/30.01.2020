using System;
using System.Collections.Generic;
using System.Text;

namespace ReadonlyAndConst
{
    class Phone
    {
        public readonly int _price=12;
        public const int _year=2021;
        public const string star = "sun";
        public Phone(int price)
        {
            _price = price;
        }
        public void Comp()
        {
            if (_year > 0)
            {
                Console.WriteLine("bla bla bla");
            }
        }
    }
}
