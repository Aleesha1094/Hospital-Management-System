using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMS
{
    public class Pharmacy
    {
        private string patientCNIC;
        private string alternativeMedicine;
        private Prescription prescription;
        public Pharmacy(string patientCNIC,string alternativeMedicine)
        {
            this.patientCNIC = patientCNIC;
            this.alternativeMedicine = alternativeMedicine;
        }

        public void LookPrsescription(Prescription prescription)
        {
            this.prescription = prescription;
        }
    }
}
