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
    public partial class login : Form
    {
        SqlConnection conn = new SqlConnection("server=DEFAULTCONNECTI;database=mail_system;uid=sa;pwd=User@123;");
        
        public login()
        {
            InitializeComponent();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 obj = new Form1();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signup obj = new signup();
            ActiveForm.Hide();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            conn.Open();
            string st = "select name from signup_form where user_name='" + loginusername.Text + "'and password='" + loginpassword.Text + "'";

            SqlCommand cmd = new SqlCommand(st, conn);
            SqlDataReader rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                Program.name = rdr[0].ToString();
                MessageBox.Show("Login Success");
                
                
                landing obj = new landing();
                ActiveForm.Hide();
                obj.Show();

            }
            else
            {
                loginusername.Text = "";
                loginpassword.Text = "";

            }
            conn.Close();
            

        }

        private void loginpassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginusername.Text = "";
            loginpassword.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loginpassword.UseSystemPasswordChar = false;
        }
    }
}
