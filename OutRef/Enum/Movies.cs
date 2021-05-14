using System;
using System.Collections.Generic;
using System.Text;

namespace Enum
{
    enum Movietype
    {
        Drama=1,
        Horror=2,
        BlockBuster=4,
        All=Drama|Horror|BlockBuster,
        All2=All|16
    }
    class Movies
    {
        public Movies(string name,Movietype type)
        {
            Name = name;
            Type = type;
        }
        public string Name { get; set; }
        public Movietype Type { get; set; }

        public override string ToString()
        {
            return $"Movie Name: {Name}" +" "+ $"Movie Type:{Type}";
        }
    }
}
