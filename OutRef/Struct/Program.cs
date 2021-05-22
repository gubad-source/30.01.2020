using System;

namespace Struct
{
  struct Student
    {
       public int id;
       public string name;
    }
    class Person
    {
        public int id;
        public string name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*Student.student*/;////////?????????????????????????????


            //Student student = new Student();
            //student.id = 1;
            //student.name = null;
            //Console.WriteLine(student.name);

            //Person person = new Person();
            //person.name = null;
            //Console.WriteLine("***" +person.name+ "***");


            Student s = default(Student);
            s.id = 1;
            Console.WriteLine(s.id);

            //Person p = default(Person);
            //p.id = 1;
            //Console.WriteLine(p.id);
           

        }
    }
}
