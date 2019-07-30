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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            this.Enabled = true;
        }


        string napr = "Вправо";
        int score = 0, health = 3,
        speed = 10;


        private void Game_KeyPress(object sender, KeyPressEventArgs e)
        {
            napra(napr, e.KeyChar);
            int x = pictureBox2.Location.X,
                y = pictureBox2.Location.Y;
            if (e.KeyChar == 68 || e.KeyChar == 100)
            {
                pictureBox2.Location = new Point(x + speed, y);
                napr = "Вправо";

            }
            else if(e.KeyChar == 65 || e.KeyChar == 97)
            {
                pictureBox2.Location = new Point(x - speed, y);
                napr = "Влево";
            }
        }
        int x = 0, y = 0,
        speedBox = 0;
        Random R = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox4.Location = new Point(y , x - speedBox);
            pictureBox4.Refresh();
        }

        private void napra(string napr, char kch)
        {
            if(napr == "Вправо")
            {
                if(kch == 65 || kch == 97) //a
                {
                    pictureBox2.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                    pictureBox2.Refresh();
                }
            }
            else if(napr == "Влево")
            {
                if(kch == 68 || kch == 100) //d
                {
                    pictureBox2.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
                    pictureBox2.Refresh();
                }
            }
            
        }
        private void box(int x, int y)
        {
            int xBox = pictureBox3.Location.X, xBox2 = pictureBox4.Location.X, xBox3 = pictureBox5.Location.X, xBox4 = pictureBox6.Location.X, xBox5 = pictureBox7.Location.X,
                yBox = pictureBox3.Location.Y, yBox2 = pictureBox4.Location.Y, yBox3 = pictureBox5.Location.Y, yBox4 = pictureBox6.Location.Y, yBox5 = pictureBox7.Location.Y;
            Random R = new Random();
            x = R.Next(this.ClientSize.Width - pictureBox3.Width);
            for (int i = 0; i < this.Height; i++)
            {
                pictureBox3.Location = new Point(xBox + 8, yBox);
            }
        }
    }
}
