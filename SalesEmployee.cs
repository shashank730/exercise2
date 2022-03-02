using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class SalesEmployee :Employee
    {
        private decimal _salesbonus;
        public SalesEmployee(string name,decimal basepay,decimal salesbonus):base(name,basepay)
        {
           _salesbonus = salesbonus;
        }
        //public override decimal CalculatePay()
        public sealed override decimal CalculatePay()
        {
            return _basepay + _salesbonus;
        }
    }
}
