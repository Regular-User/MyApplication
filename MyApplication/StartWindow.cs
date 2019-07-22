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
            StreamReader search_login = new StreamReader("Users/Login.txt");
            StreamReader search_password = new StreamReader("Users/Password.txt");



            while (!search_login.EndOfStream)
            {
                if(search_login.ReadLine() == login)
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
                                MessageBox.Show("Вы вошли");
                            }
                        }
                        else if(textBox4.Text == "")
                        {
                            label1.ForeColor = Color.Red;
                            label1.Text = "Введите пароль.";
                        }
                        else
                        {
                            label1.ForeColor = Color.Red;
                            label1.Text = "Неверный логин или пароль";
                        }
                        nump++;
                    }
                    break;
                }
                else if (textBox3.Text == "" && textBox4.Text == "")
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "Введите логин и пароль.";
                }
                else if(textBox3.Text == "")
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "Введите логин.";
                }
                else 
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "Такого пользователя не существует";
                }
                numl++;
            }
            search_login.Close();
            search_password.Close();
        }
    
        private void button3_Click(object sender, EventArgs e)

        {
            Form sn = new SignIn();
            sn.Show();
            
        }
    }
}
