using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HMS.BAL;
using HMS.DAL;
namespace HMS.PAL
{
    public partial class Add_Data : Form
    {
        public Add_Data()
        {
            InitializeComponent();
        }
        public void FillDepartment()
        {
            try
            {
                SqlConnection connection = DAL.DAL.GetConnection();
                string query = "SELECT * FROM DOCTOR;";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cmbDepartment.Items.Add(reader["Dept"].ToString());
                }
                connection.Close();
            }
            catch(SqlException)
            {
                MessageBox.Show("Error");
            }
            
        }

        public void FillDocotr()
        {
            try
            {
                SqlConnection connection = DAL.DAL.GetConnection();
                string query = "SELECT * FROM DOCTOR;";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                     cmbDoctor.Items.Add(reader["Doctor_Name"].ToString());
                }
                connection.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Error");
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Data_Load(object sender, EventArgs e)
        {
            FillDepartment();
            FillDocotr();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string patientName = txtName.Text;
            int age = int.Parse(txtAge.Text);
            string address = txtAddress.Text;
            string phoneNo = txtPhoneNo.Text;
            string gender = cmbGender.Text;
            string cnic = txtCNIC.Text;
            string department = cmbDepartment.Text;
            string docotr = cmbDoctor.Text;
            string date = dtp1.Text;
            string time = cmbTime.Text;
            Patient p1 = new Patient(cnic, patientName, phoneNo, address, gender, age);
            Appointment a1 = new Appointment(time, date);
            try
            {
                DAL.DAL.AddPatient(p1, a1);
                Portal p = new Portal();
                p.Show();
                this.Hide();
            }
            catch(Exception)
            {
                MessageBox.Show("Error in adding Patient !!!");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Portal p = new Portal();
            p.Show();
            this.Hide();
        }
    }
}
