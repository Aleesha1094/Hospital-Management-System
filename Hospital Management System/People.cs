using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMS
{
    public class People
    {
        protected string cnic;
        protected string name;
        protected string phoneNo;
        protected string address;

        public People(string cnic,string name,string phoneNo,string address)
        {
            this.cnic = cnic;
            this.name = name;
            this.phoneNo = phoneNo;
            this.address = address;
        }
    }
}
