using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Draw_Targ(int r)
        {
            Graphics g = panel1.CreateGraphics();
            int h = panel1.Height;
            int w = panel1.Width;
            Point point1 = new Point(w / 2, h / 2);
            Point point2 = new Point(w / 2, h / 2 + r + 2);
            Point point3 = new Point(w / 2 - r, h / 2 + r + 2);
            Point[] p = { point1, point2, point3 };
            Brush blue = new SolidBrush(Color.DodgerBlue);
            g.FillPie(blue, w / 2 - r, h / 2 - r + 4, r * 2, r * 2, 180, 180);
            g.FillPolygon(blue, p);
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public static void Shooting(int maX, int maY)
        {
            Graphics g = panel1.CreateGraphics();
            Random rnd = new Random();
            int x = rnd.Next(0, maX + 1);
            int y = rnd.Next(0, maY + 1);
            Brush blue = new SolidBrush(Color.Blue);
            g.FillEllipse(blue, x - 1 + panel1.Width / 2, panel1.Height / 2 - y, 4, 4);
        }

        private void StartB_Click(object sender, EventArgs e)
        {
            try
            {
                FinishB.Enabled = true;
                button1.Enabled = true;
                textBox1.Text = "";
                Calculator calc = new Calculator(Convert.ToInt32(textBox2.Text));
                calc.Calc += Demonstrator.Show;
                int x = Int32.Parse(textBox4.Text);
                int y = Int32.Parse(textBox5.Text);

                int r = Int32.Parse(textBox6.Text);
                if (r <= 0 || r >= panel1.Width / 2 || r >= panel1.Height / 2)
                    MessageBox.Show("Неверный радиус!");
                else 
                    Draw_Targ(r);
                if (x <= 0 || x >= panel1.Width / 2 || y < 0 || y >= panel1.Height / 2)
                    MessageBox.Show("Неверные координаты!");
            }
            catch (Exception)
            {
                MessageBox.Show("Неверные данные");
                textBox2.ReadOnly = false;
            }
        }

        private  void FinishB_Click(object sender, EventArgs e)
        {
            Demonstrator dm = new Demonstrator();
            dm.stopCalc += Calculator.FinishHandler;
            dm.StopCalc();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(textBox2.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверные данные!");
            }
        }
    }
}
