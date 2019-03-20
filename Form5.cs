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
    public partial class Form5 : Form
    {
        SqlCommand com = new SqlCommand();
        SqlConnection conect = new SqlConnection();
        DataSet ds = new DataSet();
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
            conect.ConnectionString = @"data source=.\sqlexpress;Initial catalog=careDB;Integrated security=True";
            SqlDataAdapter sqlDA = new SqlDataAdapter("select *  from table1", conect);
            
            conect.Open();

            sqlDA.Fill(ds, "tbl1");

            
            bindingSource1.DataSource = ds.Tables[0].DefaultView;
            
            // TODO: This line of code loads data into the 'pDataSet2.Table1' table. You can move, or remove it, as needed.
          //  this.table1TableAdapter.Fill(this.pDataSet2.Table1);
            // TODO: This line of code loads data into the 'pDataSet2.Table1' table. You can move, or remove it, as needed.
          //  this.table1TableAdapter.Fill(this.pDataSet2.Table1);
            
            Form1.ActiveForm.Hide();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.MoveNext();
            textBox2.Text = ds.Tables[0].Rows[bindingSource1.Position]["namekhodro"].ToString();
        }

        private void button4_Click(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            Form5.ActiveForm.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conect = new SqlConnection();
            SqlCommand com = new SqlCommand();
            conect.ConnectionString = @"data source=.\sqlexpress;Initial catalog=careDB;Integrated security=True";
            conect.Open();
            com.Connection = conect;
            com.CommandText = "update table1 set namekhodro=@b,noekhodro=@c,model=@d,rang=@e,tozihat=@f where pelak=@a";
            com.Parameters.AddWithValue("@b", textBox2.Text);
            com.Parameters.AddWithValue("@c", textBox3.Text);
            com.Parameters.AddWithValue("@d", textBox4.Text);
            com.Parameters.AddWithValue("@e", textBox5.Text);
            com.Parameters.AddWithValue("@f", textBox6.Text);
            com.Parameters.AddWithValue("@a", textBox1.Text);
            com.ExecuteNonQuery();
            conect.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bindingSource1.MovePrevious();

            textBox2.Text = ds.Tables[0].Rows[bindingSource1.Position]["namekhodro"].ToString();
            
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

       
    }
}