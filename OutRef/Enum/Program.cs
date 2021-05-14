using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Movies movies = new Movies("Venom",Movietype.All2);

            if (movies.Type.HasFlag(Movietype.BlockBuster))
            {
                Console.WriteLine("It is BlockBuster");
            }
            if (movies.Type.HasFlag(Movietype.Drama))
            {
                Console.WriteLine("It is Drama");
            }
            if (movies.Type.HasFlag(Movietype.Horror))
            {
                Console.WriteLine("It is Horror");
            }
            if (movies.Type.HasFlag(Movietype.All))
            {
                Console.WriteLine("It is All");
            }
            if (movies.Type.HasFlag(Movietype.All2))
            {
                Console.WriteLine("It is All2");
            }
            Console.WriteLine(movies);
        }
    }
}
