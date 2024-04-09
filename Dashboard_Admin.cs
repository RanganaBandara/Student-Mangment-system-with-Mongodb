using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace WindowsFormsApp3
{
    public partial class Dashboard_Admin : Form
    {
        public static IMongoClient client = new MongoClient();
        public static IMongoDatabase db = client.GetDatabase("studentmanagment");
        public static IMongoCollection<adminteacherinserting> collection = db.GetCollection<adminteacherinserting>("teacher");


      





        public Dashboard_Admin()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            adminteacherinserting inserting = new adminteacherinserting(textBox1.Text, textBox2.Text, textBox3.Text,textBox4.Text, textBox9.Text);
            collection.InsertOne(inserting);
            readData();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }


        private void Dashboard_Admin_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void readData()
        {
            List<adminteacherinserting> list = collection.AsQueryable().ToList();
            dataGridView1.DataSource = list;
            textBox1.Text = dataGridView1.Rows[1].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[1].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[1].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[1].Cells[3].Value.ToString();
            textBox9.Text = dataGridView1.Rows[1].Cells[4].Value.ToString();

        }
    }

    public class adminteacherinserting
        {
        private string text1;
        private string text2;
        private string text3;
        private string text4;
        private string text5;



[BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("nic")]
            public string Nic { get; set; }

            [BsonElement("Name")]
            public string Name { get; set; }

            [BsonElement("contact_number")]
            public string Contact_number { get; set; }

            [BsonElement("birthday")]
            public string Birthday { get; set; }

            [BsonElement("password")]
            public string Password { get; set; }



            public adminteacherinserting(string nic, string name, string contact_number, string birthday, string password)
            {
                Nic = nic;
                Name = name;
                Contact_number = contact_number;
                Birthday = birthday;
                Password = password;
            }

       
    }
    }






