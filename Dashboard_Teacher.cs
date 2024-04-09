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
    public partial class Dashboard_Teacher : Form
    {
        public Dashboard_Teacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            attendencemark attenmark = new attendencemark();
            attenmark.Show();
               this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            marksaddcs marksad = new marksaddcs();
            marksad.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Teacher_Load(object sender, EventArgs e)
        {

        }
    }
}
