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

// Регистрация

namespace MyApplication
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Все поля должны быть заполнены";
            }
            else if (textBox2.Text != textBox3.Text)
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Пароли не совпадают";
            }
            else
            {
                string[] strok = File.ReadAllLines("Users/Login.txt"); //строка в текстовом файле 
                if (strok.Length == 0)
                {
                    using (StreamWriter login = new StreamWriter("Users/Login.txt", true))
                    {
                        login.WriteLine(textBox1.Text);
                    }
                    using (StreamWriter password = new StreamWriter("Users/Password.txt", true))
                    {
                        password.WriteLine(textBox2.Text);
                    }
                    this.Close();
                }
                else
                {
                    string llogin = textBox1.Text;
                    bool IsHave = false;
                    for (int i = 0; i < strok.Length; i++)
                    {
                        if (strok[i] == llogin)
                        {
                            label3.ForeColor = Color.Red;
                            label3.Text = "Логин занят";
                            IsHave = true;
                            break;
                        }
                    }
                    if (!IsHave)
                    {

                        using (StreamWriter login = new StreamWriter("Users/Login.txt", true))
                        {
                            login.WriteLine(textBox1.Text);
                        }
                        using (StreamWriter password = new StreamWriter("Users/Password.txt", true))
                        {
                            password.WriteLine(textBox2.Text);
                        }
                        Form st = new StartWindow();
                        st.Activate();
                        this.Close();
                    }
                    /*
                    string llogin = textBox1.Text;
                    bool IsHave = false;
                    StreamReader search_login = new StreamReader("Users/Login.txt");
                    while (!search_login.EndOfStream)
                    {
                        if (search_login.ReadLine() == llogin)
                        {
                            label3.ForeColor = Color.Red;
                            label3.Text = "Логин занят";
                            IsHave = true;
                            search_login.Close();
                            break;
                        }
                    }
                    search_login.Close();
                    if (!IsHave)
                    {

                        using (StreamWriter login = new StreamWriter("Users/Login.txt", true))
                        {
                            login.WriteLine(textBox1.Text);
                        }
                        using (StreamWriter password = new StreamWriter("Users/Password.txt", true))
                        {
                            password.WriteLine(textBox2.Text);
                        }
                        Form st = new StartWindow();
                        st.Activate();
                        this.Close();
                    }
                    */
                }
            }
        }


        //Скрыть/показать пароль
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '\0';
            if(checkBox1.Checked == false)
            {
                textBox2.PasswordChar = '*';
            }
        }

    }
}
