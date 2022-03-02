using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class liveshow:Entertainment
    {

        string category;
        int price;
        public liveshow() { }
        public liveshow( string name,int visitors,string category,int price) : base( name,visitors)

        {
            this.category = category;
            this.price = price;
           
        }
        public string Category { get { return category; } set { category = value; } }
        public int Price { get { return price; } set { price = value; } }
    }
}
