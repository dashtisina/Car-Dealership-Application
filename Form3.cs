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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pDataSet.Table1' table. You can move, or remove it, as needed.
           // this.table1TableAdapter.Fill(this.pDataSet.Table1);
            // TODO: This line of code loads data into the 'pDataSet.Table1' table. You can move, or remove it, as needed.
           // this.table1TableAdapter.Fill(this.pDataSet.Table1);
            Form1.ActiveForm.Hide();
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                SqlConnection conect = new SqlConnection();
                SqlCommand com = new SqlCommand();
                conect.ConnectionString = @"data source=.\sqlexpress;Initial catalog=careDB;Integrated security=True";
                conect.Open();
                com.Connection = conect;
                com.CommandText = "delete from table1 where pelak=@b";

                com.Parameters.AddWithValue("@b", textBox1.Text);

                com.ExecuteNonQuery();
                conect.Close();
            
        }
       
    
    

        private void button2_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}