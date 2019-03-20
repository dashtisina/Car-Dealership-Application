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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand();
            SqlConnection conect = new SqlConnection();
            DataSet ds = new DataSet();
            SqlDataAdapter sqlDA = new SqlDataAdapter("select *  from table1",conect);
            conect.ConnectionString = @"data source=.\sqlexpress;Initial catalog=careDB;Integrated security=True";
            conect.Open();

            sqlDA.Fill(ds, "carList");

            dataGridView1.DataSource = ds.Tables[0].DefaultView;


        }
    }
}
