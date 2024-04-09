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
    public partial class marksaddcs : Form
    {
        public static IMongoClient client = new MongoClient();
        public static IMongoDatabase db = client.GetDatabase("studentmanagment");
        public static IMongoCollection<marking> collection = db.GetCollection<marking>("marks");
        public marksaddcs()
        {
            InitializeComponent();
        }

        private void marksaddcs_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            marking markmarking  = new marking(listBox3.Text, listBox1.Text,listBox2.Text,textBox3.Text,textBox2.Text);
            collection.InsertOne(markmarking);
            this.Hide();
        }
        public class marking
        {
            private string text1;
            private string text2;
            private string text3;
            private string text4;
            private string text5;





            [BsonId]
            public ObjectId Id { get; set; }

            [BsonElement("teacher_id")]
            public string Teacher_id { get; set; }

            [BsonElement("subjectname")]
            public string Subjectname { get; set; }

            

            [BsonElement("class_id")]
            public string Class_id { get; set; }

            [BsonElement("student_id")]
            public string Student_id { get; set; }

            [BsonElement("marking")]
            public string mark { get; set; }
            public marking(string teacher_id, string subjectname, string class_id, string student_id,string Mark)
            {
                Teacher_id = teacher_id;
                Subjectname = subjectname;
                
                Class_id = class_id;
                Student_id = student_id;
                mark = Mark;

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}