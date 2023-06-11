using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS.BAL;
using HMS.DAL;
using HMS.PAL;
namespace HMS
{
    public partial class AddPrescription : Form
    {
        public AddPrescription()
        {
            InitializeComponent();
        }

        private void AddPrescription_Load(object sender, EventArgs e)
        {

        }

        private void btnAddPrescription_Click(object sender, EventArgs e)
        {
            string Patient_CNIC = txtcnic.Text;
            string Medicine_Name = txtName.Text;
            string Medicine_Code = txtCode.Text;
            string Medicine_Dosage = txtDosage.Text;
            Prescription prescription = new Prescription(Patient_CNIC, Medicine_Name, Medicine_Code, Medicine_Dosage);
            try
            {
                DAL.DAL.AddPrescription(prescription);
                PAL.Portal p = new PAL.Portal();
                p.Show();
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Error in adding prescription !!!");
                Portal p = new Portal();
                p.Show();
                this.Hide();
            }
            
        }

        private void txtDosage_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcnic_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
