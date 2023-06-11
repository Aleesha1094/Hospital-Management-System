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
    public partial class UpdatePatient : Form
    {
        public UpdatePatient()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string CNIC_TO_Update=txtOldCNIC.Text;
            string Update_Name = txtName.Text;
            string Update_Address = txtAddress.Text;
            int Update_Age = int.Parse(txtAge.Text);
            string Update_Phone = txtCell.Text;
            string Update_Gender=txtGender.Text;
            Patient p = new Patient(CNIC_TO_Update,Update_Name, Update_Phone, Update_Address, Update_Gender, Update_Age);
            try
            {
                DAL.DAL.UpdatePatient(CNIC_TO_Update, p);
                MessageBox.Show("Patient Record Updated Successfully...");
                View v = new View();
                v.Show();
                this.Hide();
            }
            catch(SqlException)
            {
                MessageBox.Show("Error in updating record !!!!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            View v = new View();
            v.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtNewCNIC_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
