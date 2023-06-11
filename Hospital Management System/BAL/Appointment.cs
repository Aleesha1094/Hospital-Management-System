using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HMS.BAL
{
    public class Appointment
    {
        private string appointmentDate;
        private string appointmnetTime;
        private string appointmentId;
        private Patient patient;
        private Doctor doctor;
        public string AppointmentDate
        {
            get
            {
                return appointmentDate;
            }
        }
        public string AppointmentTime
        {
            get
            {
                return appointmnetTime;
            }
        }
        public Appointment(string appointmentTime,string appointmentDate)
        {
            //this.appointmentId = appointmentId;
            this.appointmentDate = appointmentDate;
            this.appointmnetTime = appointmentTime;
        }

        public void AddPatient(Patient patient)
        {
            this.patient = patient;
        }

        public void AddDoctor(Doctor doctor)
        {
            this.doctor = doctor;
        }
    }
}
