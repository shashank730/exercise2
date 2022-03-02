using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    [Serializable()]
    internal class Cat
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Age { get; set; }
        
        public void Showcat()
        {
            Console.WriteLine("Name :{0} \t Desc:{1} \t Age:{2} ", Name, Description, Age);
        }

    }
}
