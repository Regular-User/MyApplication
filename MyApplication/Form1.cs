using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = "aaa\nbbbb\nvvv";
            StreamWriter sw = new StreamWriter("text.txt");
            //sw.WriteLine(richTextBox1.Text);
            sw.WriteLine(a);
            sw.Close();

        }
    }
}
