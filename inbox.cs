﻿using System;
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
    public partial class inbox : Form
    {
        SqlConnection conn = new SqlConnection("server=DEFAULTCONNECTI;database=mail_system;uid=sa;pwd=User@123;");
        public inbox()
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

        private void inbox_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            landing obj = new landing();
            obj.Show();
        }
        public void fill()
        {
            conn.Open();

            string st = "select * from mail_body where receiver='" + Program.name+ "' ";

            SqlDataAdapter adapter = new SqlDataAdapter(st, conn);


            DataSet ds = new DataSet();
            adapter.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            conn.Close();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            fill();
        }
    }
}