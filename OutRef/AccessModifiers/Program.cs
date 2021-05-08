using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Movies movies = new Movies();
            movies.name = "Expendables";
            Console.WriteLine(movies.name);
            movies.GetActor();
            movies.AgeRestrictions = 18;
            movies.year = 2021;
            Console.WriteLine("Age restriction is: " + movies.AgeRestrictions);
            

            MoviesInheritance moviesInheritance = new MoviesInheritance();
           string x= moviesInheritance.GetProtected();

            MoviesLibrary moviesLibrary = new MoviesLibrary();
            moviesLibrary.GetAuthor();
        }
    }
}
