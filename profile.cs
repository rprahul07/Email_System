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
    
    public partial class profile : Form
    {
        SqlConnection conn = new SqlConnection("server=DEFAULTCONNECTI;database=mail_system;uid=sa;pwd=User@123;");
        public profile()
        {
            InitializeComponent();
        }
        public void fill()
        {
            conn.Open();

            string st = "select * from signup_form where name='"+Program.name+"' ";

            SqlDataAdapter adapter = new SqlDataAdapter(st,conn);
            

            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            conn.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            ActiveForm.Hide();
            login obj = new login();
            obj.Show();
        }
    }
}
