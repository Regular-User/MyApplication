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
    public partial class Sort_Vstav : Form
    {
        public Sort_Vstav()
        {           
            InitializeComponent();     
            
        }

        int[] mas;
        int left, right, razm;

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox2.Text = "";
            for(int i = 1; i < mas.Length; i++)
            {
                int current = mas[i];
                int j = i;
                while (j > 0 && current < mas[j - 1])
                {
                    mas[j] = mas[j-1];
                    j--;
                }
                mas[j] = current;
                
            }
            for (int i = 0; i < mas.Length; i++)
            {     
                richTextBox2.Text += mas[i].ToString() + ", ";
            }
        }



        private void Sort_Vstav_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            button2.Enabled = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form mw = new MainWindow();
            mw.Show();
            this.Close();

        }

        Random r = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1 != null)
            {
                button2.Enabled = true;
            }
            if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("Введите значения");
            }
            else
            {
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                left = Convert.ToInt32(textBox2.Text);
                right = Convert.ToInt32(textBox3.Text);
                razm = Convert.ToInt32(textBox1.Text);
                mas = new int[razm];

                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = r.Next(left, right);
                    richTextBox1.Text += mas[i].ToString() + ", ";
                }
            }
            


        } 
    }
}
