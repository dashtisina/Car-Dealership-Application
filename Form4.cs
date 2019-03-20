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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pDataSet.Table1' table. You can move, or remove it, as needed.
           // this.table1TableAdapter.Fill(this.pDataSet.Table1);
            // TODO: This line of code loads data into the 'pDataSet.Table1' table. You can move, or remove it, as needed.
           // this.table1TableAdapter.Fill(this.pDataSet.Table1);
            // TODO: This line of code loads data into the 'pDataSet.Table1' table. You can move, or remove it, as needed.
           // this.table1TableAdapter.Fill(this.pDataSet.Table1);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conect = new SqlConnection();
                SqlCommand com = new SqlCommand();
                conect.ConnectionString = @"data source=.\sqlexpress;Initial catalog=careDB;Integrated security=True";
                conect.Open();
                com.Connection = conect;
                com.CommandText = "select namekhodro from table1 where pelak=@b";
                com.Parameters.AddWithValue("@b", textBox1.Text);
                textBox2.Text = com.ExecuteScalar().ToString();
                conect.Close();
                SqlConnection x = new SqlConnection();
                SqlCommand y = new SqlCommand();
                x.ConnectionString = @"data source=.\sqlexpress;Initial catalog=careDB;Integrated security=True";
                x.Open();
                y.Connection = x;
                y.CommandText = "select noekhodro from table1 where pelak=@b";
                y.Parameters.AddWithValue("@b", textBox1.Text);
                textBox3.Text = y.ExecuteScalar().ToString();
                x.Close();
                SqlConnection a = new SqlConnection();
                SqlCommand b = new SqlCommand();
                a.ConnectionString = @"data source=.\sqlexpress;Initial catalog=careDB;Integrated security=True";
                a.Open();
                b.Connection = a;
                b.CommandText = "select model from table1 where pelak=@b";
                b.Parameters.AddWithValue("@b", textBox1.Text);
                textBox4.Text = b.ExecuteScalar().ToString();
                a.Close();
                SqlConnection c = new SqlConnection();
                SqlCommand d = new SqlCommand();
                c.ConnectionString = @"data source=.\sqlexpress;Initial catalog=careDB;Integrated security=True";
                c.Open();
                d.Connection = c;
                d.CommandText = "select rang from table1 where pelak=@b";
                d.Parameters.AddWithValue("@b", textBox1.Text);
                textBox5.Text = d.ExecuteScalar().ToString();
                c.Close();
                SqlConnection i = new SqlConnection();
                SqlCommand j = new SqlCommand();
                i.ConnectionString = @"data source=.\sqlexpress;Initial catalog=careDB;Integrated security=True";
                i.Open();
                j.Connection = i;
                j.CommandText = "select tozihat from table1 where pelak=@b";
                j.Parameters.AddWithValue("@b", textBox1.Text);
                textBox6.Text = j.ExecuteScalar().ToString();
                i.Close();
            }
            catch
            {
                MessageBox.Show("شماره پلاک مورد نظر موجود نمی باشد", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4.ActiveForm.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}