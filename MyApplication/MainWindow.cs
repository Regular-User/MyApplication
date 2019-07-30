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
            if (e.KeyChar == 87 || e.KeyChar == 119) 
            {
                if (pictureBox1.Top >= 0)
                {
                    pictureBox1.Location = new Point(x, y - 8); // w
                    napr = "Вверх";
                }
            }
            else if(e.KeyChar == 83 || e.KeyChar == 115)
            {
                if(pictureBox1.Top + 42 <= this.Height - pictureBox1.Height)
                {
                    pictureBox1.Location = new Point(x, y + 8); // s
                    napr = "Вниз";
                }
                
            }
            else if (e.KeyChar == 65 || e.KeyChar == 97)
            {
                pictureBox1.Location = new Point(x - 8, y); // a
                napr = "Влево";
            }
            else if (e.KeyChar == 68 || e.KeyChar == 100)
            {
                pictureBox1.Location = new Point(x + 8, y); // d
                napr = "Вправо";
            }
        }
        
        public void napra(string nap, char kch)
        {
            if (napr == "Вверх")
            {
                if (kch == 83 || kch == 115) //s
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                }
                else if (kch == 65 || kch == 97) //a
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
                }
                else if (kch == 68 || kch == 100) //d
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
                }
                pictureBox1.Refresh();
            }
            else if (nap == "Вниз")
            {
                if (kch == 87 || kch == 119) //w
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                }
                else if (kch == 65 || kch == 97) //a
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
                }
                else if (kch == 68 || kch == 100) //d
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
                }
                pictureBox1.Refresh();

            }
            else if (nap == "Вправо")
            {
                if (kch == 87 || kch == 119) //w
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
                }
                else if (kch == 65 || kch == 97) //a
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                                    }
                if (kch == 83 || kch == 115) //s
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
                }
                pictureBox1.Refresh();
            }
            else if (nap == "Влево")
            {
                if (kch == 87 || kch == 119) //w
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
                }
                else if (kch == 68 || kch == 100) //d
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                }
                if (kch == 83 || kch == 115) //s
                {
                    pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
                }
                pictureBox1.Refresh();
            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            Form gm = new Game();
            this.Hide();
            gm.Show();
        }
    }
}
