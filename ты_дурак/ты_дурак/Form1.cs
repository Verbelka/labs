using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ты_дурак
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_yes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Что я могу сказать? \nТы дурак.");
        }

        int t = 10, z = 10;
        private void button_no_MouseMove(object sender, MouseEventArgs e)
        {
            if (textBox1.Text != "1212")
            {
                int x = 20;
                if (button_no.Left > 10 && button_no.Right < (this.ClientSize.Width - 10))
                    button_no.Left += t;
                else
                {
                    if (button_no.Left <= 10)
                        x = -x;
                    t = -t;
                    button_no.Left -= x;
                }
                if (button_no.Top > 10 && button_no.Bottom < (this.ClientSize.Height - 10))
                    button_no.Top += z;
                else
                {
                    if (button_no.Top <= 10)
                        x = -x;
                    z = -z;
                    button_no.Top -= x;
                }
            }
        }

        private void button_no_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "1212")
                MessageBox.Show("Хм...\nА вы совсем не дурак!");
        }

       
    }
}
