using System;
using System.Collections.Generic;
using System.Text;

namespace OutRef
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Fathername { get; set; }

        public Student(string name)
        {
            this.Name = name;
        }
        public Student(string name,string surname)
            :this(name)
        {
            this.Surname = surname;
        }
        public Student(string name, string surname,string fathername)
            :this(name,surname)
        {
            this.Fathername = fathername;
        }
    }
   
}
