using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class distributor:Customer
    {
        string area;
        public string Area { get { return area; } set { area = value; } }
        public distributor()
        { }
        public distributor(int id, string name, string mail, string phone,string area):base(id,name,mail,phone)
        {
            this.area = area;
        }
    }

}
