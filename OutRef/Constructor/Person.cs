using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    public class Person
    {
        /// <summary>
        /// Oz klassinin konstruktoruna parametr oturende ***this:*** istifade olunur
        /// </summary>
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fathername { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public Person(string name,string surname)
            :this(name)
        {
            Surname = surname;
        }
        public Person(string name, string surname,string fathername)
            :this(name,surname)
        {
            Fathername = fathername;
        }
        public override string ToString()
        {
            return $"{Name}|{Surname}|{Fathername}";
        }
    }
}
