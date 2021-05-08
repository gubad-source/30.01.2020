using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    class MoviesLibrary:Movies
    {
        public void GetAuthor()
        {
            Console.WriteLine(authorName.ToUpper());
        }
    }
}
