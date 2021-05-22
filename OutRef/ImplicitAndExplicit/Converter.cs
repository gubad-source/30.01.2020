using System;
using System.Collections.Generic;
using System.Text;

namespace ImplicitAndExplicit
{
    class Converter
    {
        public int Dollar { get; set; }
        public int Cent { get; set; }

        public static implicit operator Converter(decimal value)
        {
            //3          //3.60
            int dollar = (int)value;

            value -= dollar;

            int cent = (int)(value * 100);

            return new Converter()
            {
                Dollar=dollar,
                Cent=cent
            };
        }
        public override string ToString()
        {
            return $"It is {Dollar} dollar and {Cent} cent";
        }
    }
}
