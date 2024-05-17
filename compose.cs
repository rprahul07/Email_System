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
    
    public partial class compose : Form

    {
        SqlConnection conn = new SqlConnection("server=DEFAULTCONNECTI;database=mail_system;uid=sa;pwd=User@123;");
        public compose()
        {
            InitializeComponent();
            fillcombo();
        }

        public void fillcombo()
        {
            conn.Open();

            textBox1.Text = Program.name;

            string str = "select name from signup_form";
            SqlCommand cmd = new SqlCommand(str, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
                
            }
            conn.Close();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            string str = "insert into mail_body values( '" + textBox1.Text + "','" + comboBox1.Text + "','" + textBox3.Text+ "','" + textBox4.Text + "')";
            SqlCommand cmd = new SqlCommand(str, conn);
            if (cmd.ExecuteNonQuery() > 0)
            {
                CONFIRMATION obj = new CONFIRMATION();
                obj.Show();

               
            }
            conn.Close();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            landing obj = new landing();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
