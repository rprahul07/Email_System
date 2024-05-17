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
    public partial class sent : Form
    {
        SqlConnection conn = new SqlConnection("server=DEFAULTCONNECTI;database=mail_system;uid=sa;pwd=User@123;");
        public sent()
        {
            InitializeComponent();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            landing obj = new landing();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
       

        public void fill()
        {
            conn.Open();

            string st = "select * from mail_body where sender='" +Program.name+"' ";

            SqlDataAdapter adapter = new SqlDataAdapter(st, conn);


            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            conn.Close();

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            fill();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
