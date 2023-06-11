using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using HMS.BAL;
namespace HMS.DAL
{
    class DAL
    {
        //T o get Connection from the database
        public static SqlConnection GetConnection()
        {
            string strconnection = @"Data Source=MANI\SQLEXPRESS;Initial Catalog=Project_KIA;Integrated Security=True";
            SqlConnection connection = new SqlConnection(strconnection);
            try
            {
                connection.Open();
               // MessageBox.Show("Connection was Successfull !!!");
            }
            catch(SqlException)
            {
                MessageBox.Show("Connection was Unsuccessfull !!");
                connection.Close();
            }
            return connection;
        }
        // To get Data from the Patient Table
        public static SqlDataReader GetPatientData()
        {
            SqlConnection connection = DAL.GetConnection();
            string query = "SELECT * FROM PATIENT";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        // To get Data from the Doctor Table
        public static SqlDataReader GetDoctorData()
        {
            SqlConnection connection = DAL.GetConnection();
            string query = "SELECT * FROM DOCTOR";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        //To get Data from the PrescriptionTable
        public static SqlDataReader GetPrescriptionFormCNIC(string CNIC)
        {
            SqlConnection connection = DAL.GetConnection();
            string query = "SELECT * FROM PRESCRIPTION WHERE Patient_CNIC=@CNIC;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CNIC", CNIC);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        //Login verification
       
        // To Make Appointment whenever Patient Clicks the Patient button from the portal
        public static void AddPatient(Patient patient,Appointment appointment)
        {
            string query = "INSERT INTO PATIENT(Patient_CNIC,Patient_Name,Adress,Age,Gender,CellNo) VALUES(@Patient_CNIC,@Patient_Name,@Address,@Age,@Gender,@CellNo) INSERT INTO APPOINTMENT(Appointment_Date,Appoitment_Time,Patient_CNIC) VALUES(@appointmentDate,@appointmentTime,@patientCNIC);";
            SqlConnection connection = DAL.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Patient_CNIC", patient.CNIC);
            command.Parameters.AddWithValue("@Patient_Name", patient.Name);
            command.Parameters.AddWithValue("@Address", patient.Address);
            command.Parameters.AddWithValue("@Age", patient.Age);
            command.Parameters.AddWithValue("@Gender", patient.Gender);
            command.Parameters.AddWithValue("@CellNo", patient.PhoneNo);
            command.Parameters.AddWithValue("@appointmentDate",appointment.AppointmentDate);
            command.Parameters.AddWithValue("@appointmentTime",appointment.AppointmentTime);
            command.Parameters.AddWithValue("@patientCNIC",patient.CNIC);
            command.ExecuteNonQuery();
        }
        // To Add Prescription 
        public static void AddPrescription(Prescription prescription)
        {
            string query = "INSERT INTO PRESCRIPTION(Medicine_Code,Medicine_Name,Medicine_Dozage,Patient_CNIC) VALUES(@code,@name,@dosage,@Patient_CNIC)";
            SqlConnection connection = DAL.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@code",prescription.MedicineCode);
            command.Parameters.AddWithValue("@name",prescription.MedicineName);
            command.Parameters.AddWithValue("@dosage",prescription.Dosage);
            command.Parameters.AddWithValue("@Patient_CNIC",prescription.PatientCnic);
            command.ExecuteNonQuery();
        }

       // To Search Patient Record
        public static SqlDataReader GetPatientDataFromCNIC(string CNIC)
        {
            SqlConnection connection = DAL.GetConnection();
            string query = "SELECT * FROM PATIENT WHERE Patient_CNIC=@CNIC;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CNIC", CNIC);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        // To Update Patient Record
        public static void UpdatePatient(string CNIC_TO_UPDATE,Patient patient)
        {
            string query = "UPDATE PATIENT SET Patient_Name=@Patient_Name,Adress=@Address,Age=@Age,Gender=@Gender,CellNo=@CellNo  WHERE Patient_CNIC=@CNIC_to_Update;";
            SqlConnection connection = DAL.GetConnection();
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Patient_Name", patient.Name);
            command.Parameters.AddWithValue("@Address", patient.Address);
            command.Parameters.AddWithValue("@Age", patient.Age);
            command.Parameters.AddWithValue("@Gender", patient.Gender);
            command.Parameters.AddWithValue("@CellNo", patient.PhoneNo);
            command.Parameters.AddWithValue("@CNIC_to_Update", CNIC_TO_UPDATE);
            command.ExecuteNonQuery();
        }
    }
}
