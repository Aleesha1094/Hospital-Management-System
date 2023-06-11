using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS.DAL;
using HMS.BAL;
using System.Data.SqlClient;
namespace HMS.PAL
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }

        private void btnaddrecord_Click(object sender, EventArgs e)
        {
            Doctor_Record d = new Doctor_Record();
            d.Show();
            this.Hide();
             
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            SearchPatientRecord s = new SearchPatientRecord();
            s.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Portal p = new Portal();
            p.Show();
            this.Hide();
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            Display d = new Display();
            d.Show();
            this.Hide();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            UpdatePatient a = new UpdatePatient();
            a.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
