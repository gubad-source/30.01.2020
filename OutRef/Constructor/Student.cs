using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    class Student:Person
    {
        /// <summary>
        /// Inheritance aldigi klassin konstruktoruna parametr oturende ***base:*** istifade olunur
        /// </summary>
        /// <param name="name"></param>
        public Student(string name)
            :base(name)
        {

        }
        public Student(string name,string surname)
            :base(name,surname)
        {

        }
        public Student(string name, string surname,string fathername)
          : base(name, surname,fathername)
        {

        }

        public override string ToString()
        {
            return $"{Name}|{Surname}|{Fathername}";
        }
    }
}
