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
    public partial class StartWindow : Form
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form mw = new MainWindow();
            mw.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter login = new StreamWriter("Users/Login.txt", true);
            StreamWriter password = new StreamWriter("Users/Password.txt", true);
            login.WriteLine(textBox1.Text);
            password.WriteLine(textBox2.Text);
            password.Close();
            login.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string login = textBox3.Text;
            string password = textBox4.Text;
            int numl = 1, nump = 1;
            StreamReader search_login = new StreamReader("Users/Login.txt");
            StreamReader search_password = new StreamReader("Users/Password.txt");
            while (!search_login.EndOfStream)
            {
                if (search_login.ReadLine() == login)
                {
                    
                    while (!search_password.EndOfStream)
                    {
                        if(search_password.ReadLine() == password)
                        {
                            if(nump == numl) 
                                MessageBox.Show("yeeeees", "Log-In");
                            
                        }
                        nump++;
                    }
                    break;
                }
                numl++;
            }
            search_login.Close();
            search_password.Close();
        }   
    }
}
