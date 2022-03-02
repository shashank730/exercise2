using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class Employee
    {
        public string Name { get; set; }
        protected decimal _basepay;
        public Employee(string name,decimal basepay)
        {
            Name = name;
            _basepay = basepay;
        }
       
        public virtual decimal CalculatePay()
       
        {
            return _basepay;

        }


    }
}
