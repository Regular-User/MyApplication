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
    public partial class MainWindow : Form
    {
        
        public MainWindow()
        {
            InitializeComponent();
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form mw = new MainWindow();
            Form sort = new Sort_Vstav();
            sort.Show();
            mw.Close();
            this.Hide();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Form runbut = new RunButton();
            Form mw = new MainWindow();
            runbut.Show();
            mw.Close();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Str = new String();
            Str.Hide();
            this.Close();
        }
        string napr = "Вверх";
        private void button3_KeyPress(object sender, KeyPressEventArgs e)
        {
            napra(napr, e.KeyChar);
            int x =pictureBox1.Location.X, y = pictureBox1.Location.Y;
            if(e.KeyChar == 87 || e.KeyChar == 119)
            {
                pictureBox1.Location = new Point(x, y - 8); // w
                napr = "Вверх";
            }
            else if(e.KeyChar == 83 || e.KeyChar == 115)
            {
                pictureBox1.Location = new Point(x, y + 8); // s
            }
            else if (e.KeyChar == 65 || e.KeyChar == 97)
            {
                pictureBox1.Location = new Point(x - 8, y); // a
                
            }
            else if (e.KeyChar == 68 || e.KeyChar == 100)
            {
                pictureBox1.Location = new Point(x + 8, y); // d
            }
        }
        public void napra(string nap, char kch)
        {
            if (nap == "Вверх")
            {
                if (kch == 83 || kch == 115)
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                }
                else if (kch == 65 || kch == 97)
                {

                }
                else if (kch == 68 || kch == 100)
                {

                }
            }
            else if (nap == "Вправо") ;
        }
        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("en-US"));
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
            button3.Focus();
        }
    }
}
