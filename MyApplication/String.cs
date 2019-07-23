using System;
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
    public partial class String : Form
    {
        public String()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            richTextBox1.Text = "Обрезка строки\n" + a.Substring(2, 5) + "\n" + 
                a.Substring(a.Length - 3, 3) + "\n" + a.Substring(0, 5) + "\n";
            richTextBox1.Text += "Замена символов\n" + a.Replace(" ", "").Replace('ю', 'э') + "\n";
            richTextBox1.Text += "Ремув\n" + a.Remove(2, 5);
            string found = textBox2.Text;
            int b = a.IndexOf(found);
            int c = found.Length;
            MessageBox.Show(a.Remove(b , c).Replace("  " , " "));
            // Trim ??
            // ToLower ??
            // ToUpper ??
            // TrimEnd ??
            // TrimStart ??
        }
    }
}
