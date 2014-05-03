using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MR_Corporation
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                string key = textBox1.Text;


                if (key.Length != 7)
                {
                    MessageBox.Show("Error. The number of digits must be 7. Please try again!");
                    return;
                }
                int[] tver = new int[7];
                for (int i = 0; i < 7; i++)
                    try
                    {
                        tver[i] = int.Parse(key[i].ToString());
                    }
                    catch
                    {
                        MessageBox.Show("Error. All digits must be only numbers. Please try again.");
                        return;
                    }


                string s = "";



                if (tver[0] == 0) s += 0;
                if (tver[0] == 1) s += 9;
                if (tver[0] == 2) s += 8;
                if (tver[0] == 3) s += 7;
                if (tver[0] == 4) s += 6;
                if (tver[0] == 5) s += 5;
                if (tver[0] == 6) s += 4;
                if (tver[0] == 7) s += 3;
                if (tver[0] == 8) s += 2;
                if (tver[0] == 9) s += 1;

                /*The second bite*/
                if (tver[1] == 0) s += 8;
                if (tver[1] == 1) s += 7;
                if (tver[1] == 2) s += 6;
                if (tver[1] == 3) s += 5;
                if (tver[1] == 4) s += 4;
                if (tver[1] == 5) s += 3;
                if (tver[1] == 6) s += 2;
                if (tver[1] == 7) s += 1;
                if (tver[1] == 8) s += 0;
                if (tver[1] == 9) s += 9;

                /*The third bite*/
                if (tver[2] == 0) s += 7;
                if (tver[2] == 1) s += 6;
                if (tver[2] == 2) s += 5;
                if (tver[2] == 3) s += 4;
                if (tver[2] == 4) s += 3;
                if (tver[2] == 5) s += 2;
                if (tver[2] == 6) s += 1;
                if (tver[2] == 7) s += 0;
                if (tver[2] == 8) s += 9;
                if (tver[2] == 9) s += 8;

                /*The forth bite*/
                if (tver[3] == 0) s += 2;
                if (tver[3] == 1) s += 1;
                if (tver[3] == 2) s += 0;
                if (tver[3] == 3) s += 9;
                if (tver[3] == 4) s += 8;
                if (tver[3] == 5) s += 7;
                if (tver[3] == 6) s += 6;
                if (tver[3] == 7) s += 5;
                if (tver[3] == 8) s += 4;
                if (tver[3] == 9) s += 3;

                /*The fifth bite*/
                if (tver[4] == 0) s += 1;
                if (tver[4] == 1) s += 0;
                if (tver[4] == 2) s += 9;
                if (tver[4] == 3) s += 8;
                if (tver[4] == 4) s += 7;
                if (tver[4] == 5) s += 6;
                if (tver[4] == 6) s += 5;
                if (tver[4] == 7) s += 4;
                if (tver[4] == 8) s += 3;
                if (tver[4] == 9) s += 2;

                /*The sixth bite*/
                if (tver[5] == 0) s += 2;
                if (tver[5] == 1) s += 1;
                if (tver[5] == 2) s += 0;
                if (tver[5] == 3) s += 9;
                if (tver[5] == 4) s += 8;
                if (tver[5] == 5) s += 7;
                if (tver[5] == 6) s += 6;
                if (tver[5] == 7) s += 5;
                if (tver[5] == 8) s += 4;
                if (tver[5] == 9) s += 3;

                /*The seventh bite*/
                if (tver[6] == 0) s += 6;
                if (tver[6] == 1) s += 5;
                if (tver[6] == 2) s += 4;
                if (tver[6] == 3) s += 3;
                if (tver[6] == 4) s += 2;
                if (tver[6] == 5) s += 1;
                if (tver[6] == 6) s += 0;
                if (tver[6] == 7) s += 9;
                if (tver[6] == 8) s += 8;
                if (tver[6] == 9) s += 7;


                textBox2.Text = s;
            }
        }
    }
}
