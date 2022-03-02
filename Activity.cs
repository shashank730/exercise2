using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class Activity:Bank,IWalk
    {
        public void Makeit()
        {
            Console.WriteLine("we are walking");
        }
        public void  Doit()
        {
            Console.WriteLine("we are flying");
        }
        public override double RateofInterest()
        {
            //row new NotImplementedException();
        
        
            return 8.5;
        }


    }
}
