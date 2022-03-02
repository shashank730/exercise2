using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    public class Entertainment
    {


        string name;
        int visitors;


        public Entertainment()
        {
        }
        public Entertainment(string name, int visitors)
        {

            this.name = name;
            this.visitors = visitors;

        }


        public string Name { get { return name; } }
        public int Visitors { get { return visitors; } }
    }

    
}
