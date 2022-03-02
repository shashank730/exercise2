using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    public abstract class Bank
    {
        //abstract method
        public abstract double RateofInterest();

        // non abstract method
        public void show()
        {
            Console.WriteLine("it is a non abstract method");
        }
    }
}
