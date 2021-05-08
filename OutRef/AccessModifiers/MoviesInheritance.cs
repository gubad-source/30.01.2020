using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
   class MoviesInheritance:Movies
    {
        public void GetAuthor()
        {
            Console.WriteLine(authorName);
        }
        
       public string GetProtected()
        {
            return country.ToString();
            
        }
       public void GetYear()
        {
            Console.WriteLine(year);
        }
    }
}
