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
namespace HMS.PAL
{
    public partial class Search_Record : Form
    {
        public Search_Record()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Search_CNIC = txtSearchCNIC.Text;
            SqlDataReader reader=DAL.DAL.GetPrescriptionFormCNIC(Search_CNIC);
            DataTable table = new DataTable();
            table.Load(reader);
            dgvSearch.DataSource = table;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Portal p = new Portal();
            p.Show();
            this.Hide();
        }
    }
}
