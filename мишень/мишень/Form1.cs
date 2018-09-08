using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace мишень
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Draw_Targ(int r)
        {
            Graphics g = target.CreateGraphics();
            int h = target.Height;
            int w = target.Width;
            Point point1 = new Point(w / 2, h / 2);
            Point point2 = new Point(w / 2, h / 2 + r + 2);
            Point point3 = new Point(w / 2 - r, h / 2 + r + 2);
            Point[] p = { point1, point2, point3 };
            Brush blue = new SolidBrush(Color.DodgerBlue);
            g.FillPie(blue, w/2 - r, h/2 - r + 4 ,r * 2, r * 2, 180, 180);
            g.FillPolygon(blue, p);
        }

        private bool RightShoot(int x, int y)
        {
            int r = Int32.Parse(textBoxR.Text);
            if (x >= 0 && y >= 0 && x * x + y * y <= r * r)
                return true;
            else if (y <= 0 && x >= -r && y >= -r && x >= y && x <= 0) 
                return true;
            return false;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                int r = Int32.Parse(textBoxR.Text);
                int kol = Int32.Parse(textBoxShoot.Text);
                if (r <= 0 || kol <= 0 || r >= target.Width / 2 || r >= target.Height / 2)
                    MessageBox.Show("Неверный радиус или количество выстрелов!");
                else
                {
                    buttonShoot.Enabled = true;
                    buttonStart.Enabled = false;
                    textBoxR.Enabled = false;
                    textBoxX.Enabled = true;
                    textBoxY.Enabled = true;
                    textBoxShoot.Enabled = false;
                    label1.Text = kol.ToString();
                    Draw_Targ(r);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void buttonShoot_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(label1.Text) == 0)
            {
                int n = Int32.Parse(labelYesS.Text);
                int t = Int32.Parse(textBoxShoot.Text);
                if (n > t / 2)
                    MessageBox.Show(n + " из " + t + "\nВы отличный стрелок!");
                else
                    MessageBox.Show(n + " из " + t + "\nВ следующий раз повезет больше!:)");
                MessageBox.Show("Патроны закончились.\nНажмите 'Заново' для перезапуска");
            }
            else
            {
                try
                {
                    Graphics g = target.CreateGraphics();
                    int x = Int32.Parse(textBoxX.Text);
                    int y = Int32.Parse(textBoxY.Text);
                    Brush blue = new SolidBrush(Color.Blue);
                    g.FillEllipse(blue, x - 1 + target.Width / 2, target.Height / 2 - y, 4, 4);
                    if (RightShoot(x, y))
                        labelYesS.Text = Convert.ToString(Int32.Parse(labelYesS.Text) + 1);
                    else
                        labelNoS.Text = Convert.ToString(Int32.Parse(labelNoS.Text) + 1);
                    label1.Text = Convert.ToString(Int32.Parse(label1.Text) - 1);
                }
                catch (Exception)
                {
                    MessageBox.Show("Ошибка!");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
