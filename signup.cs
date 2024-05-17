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

namespace Email_System
{
    public partial class signup : Form
    {
        SqlConnection conn = new SqlConnection("server=DEFAULTCONNECTI;database=mail_system;uid=sa;pwd=User@123;");
        public signup()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           string  txt1 = txtpassword.Text;
            string txt2 = txtconfirmpass.Text;
            if (txt1 == txt2)
            {
                conn.Open();
                string str = "insert into signup_form values( '" + txtname.Text + "','" + txtmob.Text + "','" + txtemail.Text + "','" + txtusrname.Text + "','" + txtpassword.Text + "')";
                SqlCommand cmd = new SqlCommand(str, conn);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("sucess");
                }
                conn.Close();
                login obj = new login();
                ActiveForm.Hide();
                obj.Show();

            }
            else
            {
                MessageBox.Show("Password Must be Same As Confirm Password");
            }
        }

        private void signup_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Form1 obj = new Form1();
            ActiveForm.Hide();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtname.Text = "";
            txtmob.Text = "";
            txtemail.Text = "";
            txtusrname.Text = "";
            txtpassword.Text = "";
            txtconfirmpass.Text = "";
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
