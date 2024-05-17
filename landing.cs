using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email_System
{
    public partial class landing : Form
    {
        public landing()
        {
            InitializeComponent();
        }

        

        

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            compose obj = new compose();
            ActiveForm.Hide();
            obj.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sent obj = new sent();
            ActiveForm.Hide();
            obj.Show();
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            inbox obj = new inbox();
            ActiveForm.Hide();
            obj.Show();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            profile obj = new profile();
            obj.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            profile obj = new profile();
            obj.Show();

        }
    }
}
