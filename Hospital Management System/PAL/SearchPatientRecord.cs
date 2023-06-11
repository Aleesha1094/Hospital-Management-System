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
using System.Data.SqlClient;
namespace HMS.PAL
{
    public partial class SearchPatientRecord : Form
    {
        public SearchPatientRecord()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Search_CNIC = txtSearchPateintCNIC.Text;
            SqlDataReader reader = DAL.DAL.GetPrescriptionFormCNIC(Search_CNIC);
            DataTable table = new DataTable();
            table.Load(reader);
            dgvPateintData.DataSource = table;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            View v = new View();
            v.Show();
            this.Hide();
        }

        private void dgvPateintData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
