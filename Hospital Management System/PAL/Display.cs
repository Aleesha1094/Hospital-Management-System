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
using HMS.DAL;
using HMS.BAL;
namespace HMS.PAL
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Display_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = DAL.DAL.GetPatientData();
            DataTable table = new DataTable();
            table.Load(reader);
            dgvDisplayPatient.DataSource = table;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            View p = new View();
            p.Show();
            this.Hide();
        }
    }
}
