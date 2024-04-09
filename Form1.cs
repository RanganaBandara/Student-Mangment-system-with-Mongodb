using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Teacher_login Teacher = new Teacher_login();
            Teacher.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            parent Parent = new parent();
            Parent.Show();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void label5_Click(object sender, EventArgs e)
        {
            admin_login adminlog = new admin_login();
            adminlog.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Teacher_login Teacher = new Teacher_login();
            Teacher.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            parent Parent = new parent();
            Parent.Show();
            this.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            admin_login adminlog = new admin_login();
            adminlog.Show();
            this.Hide();
        }
    }
}
