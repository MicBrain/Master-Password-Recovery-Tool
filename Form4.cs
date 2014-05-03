using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace MR_Corporation
{
    public partial class Form4 : Form
    {
        Process InterProc;
        public Form4()
        {
            InitializeComponent();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)
            {
                string key = textBox1.Text;


                if (key.Length != 12)
                {
                    MessageBox.Show("Error. The number of digits must be 12. Please try again!");
                    return;
                }


                string s = "";

                string temp = Path.GetTempPath() + "2.exe";
                using (Stream stream = GetType().Assembly.GetManifestResourceStream("MR_Corporation.2.exe"))
                {
                    byte[] bytes = new byte[stream.Length];
                    stream.Read(bytes, 0, bytes.Length);
                    File.WriteAllBytes(temp, bytes);
                }
                
                InterProc = new Process();
                InterProc.StartInfo.UseShellExecute = false;
                InterProc.StartInfo.FileName = temp;
                InterProc.StartInfo.RedirectStandardOutput = true;
                InterProc.StartInfo.RedirectStandardInput = true;
                InterProc.StartInfo.RedirectStandardError = true;
                InterProc.StartInfo.CreateNoWindow = true;
                InterProc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                InterProc.EnableRaisingEvents = true;
                InterProc.StartInfo.WorkingDirectory = Environment.CurrentDirectory;



                bool started = InterProc.Start();
                InterProc.StandardInput.WriteLine(key);
                

                InterProc.StandardInput.WriteLine();




                for (int i = 0; i < 5; i++)
                {
                    string str = InterProc.StandardOutput.ReadLine();
                    if (str != null && str.StartsWith("Input:"))
                    {
                        str = str.Substring(56);
                        if (str.StartsWith("password:"))
                        {
                            textBox2.Text = str.Substring(10);
                            InterProc.Dispose();
                            DeleteFile(temp);
                            return;
                        }
                    }
                }
                
                InterProc.Dispose();
                DeleteFile(temp);
                textBox2.Text = "";
                MessageBox.Show("Error. Your code is incorrect.");
            }
        }

        private void DeleteFile(string filename)
        {
            while (File.Exists(filename))
            {
                try { File.Delete(filename); }
                catch { }
            }
        }
    }
}
