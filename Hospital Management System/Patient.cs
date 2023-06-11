using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMS
{
    public class Patient : People
    {
        private string patientId;
        private string gender;
        private int age;
        private Login patientLogin;
        public Patient(string cnic,string name,string phoneNo,string address,string patientId,string gender,int age):base(cnic,name,phoneNo,address)
        {
            this.patientId = patientId;
            this.gender = gender;
            this.age = age;
        }

        public  void PatientLogin(Login patientLogin)
        {
            this.patientLogin = patientLogin;
        }
       /* public Appointment Appointment
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }*/
    }
}
