using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal interface IStudent
    {
        // auto properties
        string Name { get; set; }    
        int Count { get; }
    }
}
