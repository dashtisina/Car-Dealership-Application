using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace pp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            linkLabel1.Hide();
            monthCalendar1.Hide();
            int i;
            i = 1;
            label1.Text = i.ToString();
            timer1.Start();
        }

        private void تقویمToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void بازToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monthCalendar1.Show();
            linkLabel1.Show();
        }

        private void بستهToolStripMenuItem_Click(object sender, EventArgs e)
        {
            monthCalendar1.Hide();
            linkLabel1.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int a;
            a = Int32.Parse(label1.Text);
            a = a + 1;
            label1.Text=a.ToString();
            
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            monthCalendar1.Hide();
            linkLabel1.Hide();
        }

        private void دربارهماToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void klhdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
        }
    }
}