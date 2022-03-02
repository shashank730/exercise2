using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class Movie:Entertainment
    {
        
        string genre;
       
        public string Genre{ get { return genre; } set { genre = value; } }
        public Movie()
        { }
        public Movie(string name,int visitors, string genre) : base( name,visitors)
        {
            this.genre = genre;
        }
    }
}
