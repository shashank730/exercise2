using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class shopkeeper:Customer
    {
        string nichebusiness;
        public shopkeeper() { }
        public shopkeeper(int id,string name,string mail,string phone,string niche):base(id,name,mail,phone)
        {
            nichebusiness = niche;
        }
        public string Nichebusiness{ get { return nichebusiness; } set { nichebusiness = value; } }
    }
}
