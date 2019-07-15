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
    public partial class RunButton : Form
    {
        public RunButton()
        {
            InitializeComponent();
        }

        
        Random R = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int x,
                y,
                size1 = R.Next(50, 160),
                size2 = R.Next(50, 160),
                red = R.Next(1, 255),
                blue = R.Next(1, 255),
                green = R.Next(1, 255),
                prozrach = R.Next(1, 255);

            button1.Width = size1;
            button1.Height = size2;
            button1.BackColor = Color.FromArgb(prozrach, red, blue, green);
            x = R.Next(this.ClientSize.Width - button1.Width);
            y = R.Next(this.ClientSize.Height - button1.Height);
            button1.Location = new Point(x, y);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form mw = new MainWindow();
            mw.Show();
            this.Close();
        }
    }
}
