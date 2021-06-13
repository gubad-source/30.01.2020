using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Qubad", "Mustafayev", "Rovsen");
            Console.WriteLine(person);

            Student student = new Student("Gabil", "Gurbanov", "Nadir");
            Console.WriteLine(student);
        }
    }
}
