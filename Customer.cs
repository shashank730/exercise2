using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise1;

namespace exercise2
{
    public class Customer
    {
        int customerid;
        string name;
        string email;
        string phone;
        /* public string city;
         public string state;
         public string zipCode;
         public string country;*/
        public Customer()
        {
        }
        public Customer(int id, string name, string email, string phone)
        {
            customerid = id;
            this.name = name;
            this.email = email;
            this.phone = phone;
        }

        public int Customerid
        {
            get { return customerid; }
            set { customerid = value; }
        }
        public string Name
        { 
            get { return name; }
            set { name = value; }
        }
        public string Email
        { get { return email; } 
            set { email = value; }
        }
        public string Phone
        { get{ return phone; }
            set { phone = value; }
        }


    }

}

