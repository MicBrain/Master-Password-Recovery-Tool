using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MR_Corporation
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();
        Form4 f4 = new Form4();
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                f2.Show();
            }
            catch
            {
                f2 = new Form2();
                f2.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                f3.Show();
            }
            catch
            {
                f3 = new Form3();
                f3.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                f4.Show();
            }
            catch
            {
                f4 = new Form4();
                f4.Show();
            }
        }
    }
}
