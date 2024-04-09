using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WindowsFormsApp3
{
    public partial class attendencemark : Form
    {
        public static IMongoClient client = new MongoClient();
        public static IMongoDatabase db = client.GetDatabase("studentmanagment");
        public static IMongoCollection<attendencemarking> collection = db.GetCollection<attendencemarking>("attendence");

        public attendencemark()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Text = textBox1.Text;

        }

        private void attendencemark_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            attendencemarking attenmark = new attendencemarking(listBox1.Text, listBox2.Text);
            collection.InsertOne(attenmark);
            readdata();



        }
        public void readdata()
        {
            List<attendencemarking> list = collection.AsQueryable().ToList();
            dataGridView1.DataSource = list;
            textBox1.Text = dataGridView1.Rows[1].Cells[0].Value.ToString();
            listBox1.Text = dataGridView1.Rows[1].Cells[1].Value.ToString();
        }
        public class attendencemarking
        {
            private string text1;
            private string text2;




            [BsonId]
            public ObjectId Id { get; set; }

            [BsonElement("Student_id")]
            public string Stu_id { get; set; }

            [BsonElement("Attendence_value")]
            public string Attendence_value { get; set; }




            public attendencemarking(string stu_id, string attendence_value)
            {
                Stu_id = stu_id;
                Attendence_value = attendence_value;

            }

            

            }



            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
