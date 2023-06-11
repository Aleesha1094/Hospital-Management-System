using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMS
{
    public class Doctor : People
    {
        private string qualification;
        private string department;
        private string doctorId;
        private Prescription prescription;
        private Login doctorLogin;
        public Doctor(string cnic,string phoneNo,string name,string address,string qualification,string department,string doctorId):base(cnic,name,phoneNo,address)
        {
            this.qualification = qualification;
            this.department = department;
            this.doctorId = doctorId;
        }

        public void DoctorLogin(Login doctorLogin)
        {
            this.doctorLogin = doctorLogin;
        }

        public void AddPrescription(Prescription prescription)
        {
            this.prescription = prescription;
        }
       /* public Appointment Appointment
        {
            get
            {
                
            }
            set
            {
            }
        }*/
    }
}
