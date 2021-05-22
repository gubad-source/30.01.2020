using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    enum Color
    {
       Red=1,
       Black=2,
       White=4,
       All=Red|Black|White,
      Yellow=16,
      All2=All|Yellow
    }
    class Cartoon
    {
        public Cartoon(string name,Color color)
        {
            this.Name = name;
            this.color = color;
        }
        public string Name { get; set; }
        public Color color { get; set; }

        public override string ToString()
        {
            return $"Cartoon Name: {Name}\n Primary Color Of Cartoon: {color}" ;
        }
    }
}
