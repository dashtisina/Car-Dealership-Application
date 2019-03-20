using System.Data.OleDb;
using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace pp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pDataSet.Table1' table. You can move, or remove it, as needed.
           // this.table1TableAdapter.Fill(this.pDataSet.Table1);
            Form1.ActiveForm.Hide();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand();
            SqlConnection conect = new SqlConnection();

            conect.ConnectionString = @"data source=.\sqlexpress;Initial catalog=careDB;Integrated security=True";
            conect.Open();
            com.Connection = conect;
            com.CommandText = "insert into table1(namekhodro,pelak,noekhodro,model,rang,tozihat) values(@a,@b,@c,@d,@e,@f)";
            com.Parameters.AddWithValue("@a", textBox1.Text);
            com.Parameters.AddWithValue("@b", textBox2.Text);
            com.Parameters.AddWithValue("@c", textBox3.Text);
            com.Parameters.AddWithValue("@d", textBox4.Text);
            com.Parameters.AddWithValue("@e", textBox5.Text); 
            com.Parameters.AddWithValue("@f", textBox6.Text);
            com.ExecuteNonQuery();
            conect.Close();
            progressBar1.Value = 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form1 f1=new Form1();
            f1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            progressBar1.Value = 0;
        }
    }
}