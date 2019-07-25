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

            StreamWriter logintext = new StreamWriter("Users/Login.txt", true);
            StreamWriter passwordtext = new StreamWriter("Users/Password.txt", true);
            logintext.Close();
            passwordtext.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
           
            int numl = 1, nump = 1;
            string login = textBox3.Text, password = textBox4.Text;
            StreamReader search_login, search_password;

            if (login == "" || password == "")
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Поля не должны быть пустыми";
            }
            else
            {
                search_login = new StreamReader("Users/Login.txt");
                search_password = new StreamReader("Users/Password.txt");
                while (!search_login.EndOfStream)
                {
                    if (search_login.ReadLine() == login) 
                    {
                        while (!search_password.EndOfStream)
                        {
                            if (search_password.ReadLine() == password)
                            {
                                if (nump == numl)
                                {
                                    Form mw = new MainWindow();
                                    mw.Show();
                                    this.Hide();
                                    break;
                                }
                                else
                                {
                                    label1.ForeColor = Color.Red;
                                    label1.Text = "Неверный логин или пароль";
                                    break;
                                }
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
    
        private void button3_Click(object sender, EventArgs e)

        {
            Form sn = new SignIn();
            sn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form Str = new String();
            Str.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form mw = new MainWindow();
            mw.Show();
            this.Hide();
        }
    }
}