using System;
using System.Collections.Generic;
using System.Text;

namespace StaticConstructor
{
    class Fish
    {
        private static int counter = 0;
        public readonly int id;
        public string name;
        public Fish()
        {
            counter++;
            this.id = counter;
        }
        public override string ToString()
        {
            return $"{id}) {name}";
        }
    }
}
