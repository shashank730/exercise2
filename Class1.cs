using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class Class1
    {
        int number;
        public Class1(){}
        public Class1(int no)
        {
            number = no;
        }
        //operator overloading
        public static Class1 operator +(Class1 c1,Class1 c2)
        {
            Class1 c=new Class1(0);
            c.number = c1.number + c2.number;
            return c;
        }
        public void Display()
        {
            Console.WriteLine(number);
        }
    }
}
