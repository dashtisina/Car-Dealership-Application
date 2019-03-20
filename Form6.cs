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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6.ActiveForm.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            listBox2.Hide();
        }
    }
}