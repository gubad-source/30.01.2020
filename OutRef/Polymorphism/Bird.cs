using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
   sealed class Bird:Vertebrate
    {
        public string Class { get; set; }
        public string Family { get; set; }
        public string Kingdom { get; set; }
        public string Order { get; set; }
        public Bird(string Class)
        {
            this.Class = Class;
        }
        public Bird(string Class,string Family)
            :this(Class)
        {
            this.Family = Family;
        }
        public Bird(string Class, string Family,string Kingdom)
            :this(Class,Family)
        {
            this.Kingdom = Kingdom;
        }
        public Bird(string Class, string Family, string Kingdom,string Order)
            :this(Class,Family,Kingdom)
        {
            this.Order = Order;
        }
        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("it is omnivor");
        }
    }
}
