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
    public partial class login_Form : Form
    {
        public login_Form()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection strcon = DAL.DAL.GetConnection();
            string query = "SELECT Count(*) FROM LOGIN WHERE Username = @Username  and  Pasword = @Pasword;";
            SqlCommand com = new SqlCommand(query, strcon);
            com.Parameters.AddWithValue("@Username", txtusername.Text);
            com.Parameters.AddWithValue("@Pasword", txtpassword.Text);
          //  strcon.Open();
             int result = Convert.ToInt32(com.ExecuteScalar());
             strcon.Close();
             if(result == 1)
             {
                 MessageBox.Show("Login Successfull.");
            //     //strcon.Close();
                View v1 = new View();
                v1.Show();
                this.Hide();

            }
            else
             {
                MessageBox.Show("Wrong Username or Password!!!");
            //    // strcon.Close();
                login_Form l1 = new login_Form();
                l1.Show();
                this.Hide();
             }
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
