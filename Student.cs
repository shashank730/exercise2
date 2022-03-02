using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2
{
    internal class Student:IStudent
    {
        public static int no_students;
        string _name;
        int _count;

        public string Name
        {
            /* get { return _name; }
             set { _name = value; } */
            get => _name;
            set => _name = value;
        
        
        
        
        }
        public int Count => _count;

        public Student() => _count = ++no_students;

    }
}
