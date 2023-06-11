using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMS.PAL
{
    public partial class Portal : Form
    {
        public Portal()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPrescription p1 = new AddPrescription();
            p1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add_Data a2 = new Add_Data();
            a2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login_Form l1 = new login_Form();
            l1.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Search_Record s1 = new Search_Record();
            s1.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you wish to Quit", "Exit Application", MessageBoxButtons.YesNo);
            if(result==System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                Portal p = new Portal();
                p.Show();
                this.Hide();
            }
        }
    }
}
