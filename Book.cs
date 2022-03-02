using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class Book
    {
        int bookcode;
        string title;
        string author;
        double price;
        public int Bookcode { get { return bookcode; } set { bookcode = value; } }
        public string Title { get { return title; } set { title = value; } }
        public string Author { get { return author; } set { author = value; } }
        public double Price { get { return price; } set { price = value; } }

    }
}
