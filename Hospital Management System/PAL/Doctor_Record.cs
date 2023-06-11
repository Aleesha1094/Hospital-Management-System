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
    public partial class Doctor_Record : Form
    {
        public Doctor_Record()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            View p = new View();
            p.Show();
            this.Hide();
        }

        private void dgvDoctor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Doctor_Record_Load(object sender, EventArgs e)
        {
            SqlDataReader reader = DAL.DAL.GetDoctorData();
            DataTable table = new DataTable();
            table.Load(reader);
            dgvDoctor.DataSource = table;
        }
    }
}
