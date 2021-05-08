using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
   public class Movies
    {
        public string name;
        protected string country="United States Of America";
        private string actor="Sylvestor Stallone";
        internal double AgeRestrictions;
       protected internal double year;
        private protected string authorName="synider";

        public void GetActor()
        {
            Console.WriteLine(actor);
        }
    }
}
