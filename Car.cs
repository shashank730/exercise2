using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class Car:IComparable<Car>

    {
        public string Name { get; set; }   
        public int Speed { get; set; }
        public string Color { get; set; }
        public int CompareTo(Car other)
        { 
             //comapre the colors
            int compare;
            compare = String.Compare(this.Color, other.Color, true);
            // if the colors are the same,compare the speeds
            if (compare == 0)
            {
                compare=this.Speed.CompareTo(other.Speed);
                //use descending order for speed
                compare = -compare;

            }
            return compare;


        }


        
    }
}
