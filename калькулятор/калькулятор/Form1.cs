using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькулятор
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float x, y;
        bool sign = true;
        int ind;

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox1.Text.IndexOf(',') == -1)
                {
                    textBox1.Text += ",";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                ind = 1;
                x = float.Parse(textBox1.Text);
                textBox1.Clear();
                sign = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                ind = 2;
                x = float.Parse(textBox1.Text);
                textBox1.Clear();
                sign = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                ind = 3;
                x = float.Parse(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                ind = 4;
                x = float.Parse(textBox1.Text);
                textBox1.Clear();
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (sign)
                    textBox1.Text = "-" + textBox1.Text;
                else
                    textBox1.Text = textBox1.Text.Replace("-", "");
                sign = !sign;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                string buff = textBox1.Text;
                int length = textBox1.Text.Length - 1;
                textBox1.Clear();
                for (int i = 0; i < length; i++)
                    textBox1.Text = textBox1.Text + buff[i];
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Result();
                ind = 0;
            }
        }

        private void Buttons_Show(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void Result()
        {
            switch(ind)
            {
                case 1:
                    y = x + float.Parse(textBox1.Text);
                    textBox1.Text = y.ToString();
                    break;
                case 2:
                    y = x - float.Parse(textBox1.Text);
                    textBox1.Text = y.ToString();
                    break;
                case 3:
                    y = x * float.Parse(textBox1.Text);
                    textBox1.Text = y.ToString();
                    break;
                case 4:
                    if (float.Parse(textBox1.Text) != 0)
                    {
                        y = x / float.Parse(textBox1.Text);
                        textBox1.Text = y.ToString();
                    }
                    else
                        MessageBox.Show("Нельзя делить на 0!");
                    break;
            }
        }
    }
}
