using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal sealed class Teacher:SalesEmployee
    {
        string subject;
        public string Subject { get { return subject; } }
        public Teacher(string name,decimal pay,decimal bonus,string subject):base (name,pay,bonus)

        {
            this.subject = subject;
        }
        /*public override decimal CalculatePay()
        { }*/
    }
}
