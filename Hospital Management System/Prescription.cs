using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMS
{
    public class Prescription
    {
        private string patientCnic;
        private string prescriptionId;
        private string medicineName;
        private string medicineCode;
        private string dosage;

        public Prescription(string patientCnic,string prescriptionId,string medicineName,string medicineCode,string dosage)
        {
            this.patientCnic = patientCnic;
            this.prescriptionId = prescriptionId;
            this.medicineName = medicineName;
            this.medicineCode = medicineCode;
            this.dosage = dosage;
        }

        /*public Pharmacy Pharmacy
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Doctor Doctor
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
