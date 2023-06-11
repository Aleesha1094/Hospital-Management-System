using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMS
{
    public class Admin : People
    {
        private string adminId;
        private Login loginDetails;
        public Admin(string cnic,string name,string phoneNo,string address,string adminId):base(cnic,name,phoneNo,address)
        {
            this.adminId = adminId;
        }

        public void Login(Login loginDetails)
        {
            this.loginDetails = loginDetails; ;
        }
    }
}
