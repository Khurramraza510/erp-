using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace erp1
{
    public partial class Form3 : Form
    {
       
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }
    }
}
