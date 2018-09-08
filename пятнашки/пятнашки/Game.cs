using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пятнашки
{
    public partial class Game : Form
    {
        public Game()
        {
            Text = "Пятнашки";
            MaximizeBox = false;
            ClientSize = new Size(field.Size * 50 + 20, field.Size * 50 + 50);
            InitializeComponent();
        }

        private DataGridView DGV;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem менюToolStripMenuItem;
        private ToolStripMenuItem новаяИграToolStripMenuItem;
        private ToolStripMenuItem зановоToolStripMenuItem;
        private Timer timer1;
        private IContainer components;
        private Label label1;
        private TimeSpan time;
        private ToolStripMenuItem выходToolStripMenuItem;
        private Label label2;
        Field field = new Field();

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новаяИграToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зановоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeColumns = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.ColumnHeadersVisible = false;
            this.DGV.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DGV.Location = new System.Drawing.Point(59, 41);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowHeadersVisible = false;
            this.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.DGV.RowTemplate.Height = 28;
            this.DGV.Size = new System.Drawing.Size(432, 346);
            this.DGV.TabIndex = 0;
            this.DGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(565, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяИграToolStripMenuItem,
            this.зановоToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // новаяИграToolStripMenuItem
            // 
            this.новаяИграToolStripMenuItem.Name = "новаяИграToolStripMenuItem";
            this.новаяИграToolStripMenuItem.Size = new System.Drawing.Size(191, 30);
            this.новаяИграToolStripMenuItem.Text = "Новая игра";
            this.новаяИграToolStripMenuItem.Click += new System.EventHandler(this.новаяИграToolStripMenuItem_Click);
            // 
            // зановоToolStripMenuItem
            // 
            this.зановоToolStripMenuItem.Name = "зановоToolStripMenuItem";
            this.зановоToolStripMenuItem.Size = new System.Drawing.Size(191, 30);
            this.зановоToolStripMenuItem.Text = "Заново";
            this.зановоToolStripMenuItem.Click += new System.EventHandler(this.зановоToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(191, 30);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 27);
            this.label1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(314, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 27);
            this.label2.TabIndex = 3;
            // 
            // Game
            // 
            this.ClientSize = new System.Drawing.Size(565, 437);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Game_Load(object sender, EventArgs e)
        {
            DGV.ColumnCount = field.Size;
            DGV.RowCount = field.Size;
            time = new TimeSpan(0, 0, 0);
            label2.Text = "Количество ходов : 0";
            label1.Text = "Время игры : 00:00:00";
            G_Resize();
            DGV.Enabled = false;
            Make_Table();
        }

        private void G_Resize()
        {
            for (int i = 0; i < field.Size; i++)
            {
                DGV.Columns[i].Width = (DGV.Width - 4) / 4;
                DGV.Rows[i].Height = (DGV.Height - 4) / 4;
            }
        }

        int n = 0;
        private void Start_Game()
        {
            timer1.Interval = 1000;
            label2.Text = "Количество ходов : " + n.ToString();
            label1.Text = "Время игры : " + time.ToString();
            if (Check_Winner())
            {
                MessageBox.Show("Победа!!! \nВаш результат : " + time.ToString() + "\n" + n + " ходов");
                timer1.Stop();
                this.Close();
            }
            Make_Table();
        }
        
        private void Make_Table()
        {
            DGV.DefaultCellStyle.Font = new Font("Harlow Solid Italic", 20f);
            DGV.DefaultCellStyle.ForeColor = Color.Black;
            DGV.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DGV.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;

            for (int i = 0; i < field.Size; i++)
            {
                for (int j = 0; j < field.Size; j++)
                {
                    if (field.Numbers[i, j] != 16)
                    {
                        DGV.Rows[i].Cells[j].Style.BackColor = Color.Violet;
                        DGV.Rows[i].Cells[j].Value = field.Numbers[i, j].ToString();
                    }
                    else
                    {
                        DGV.Rows[i].Cells[j].Style.BackColor = Color.SlateBlue;
                        DGV.Rows[i].Cells[j].Value = "";
                    }
                    DGV.Rows[i].Cells[j].Selected = false;
                }
            }
            if (Check_Winner())
                field.Mix();
        }

        private bool Check_Winner()
        {
            int index = 1;
            for (int i = 0; i < field.Size; i++)
            {
                for (int j = 0; j < field.Size; j++)
                {
                    if (field.Numbers[i, j] != index)
                        return false;
                    index++;
                }
            }
            return true;
        }

        private void Game_Resize(object sender, EventArgs e)
        {
            G_Resize();
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            field.Save();
            timer1.Stop();            
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            time += new TimeSpan(0, 0, 1);
            label1.Text = "Время игры : " + time.ToString();
        }

        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DGV.Enabled = true;
            time = new TimeSpan(0,0,0);
            timer1.Start();
            n = 0;
            field.Mix();
            Start_Game();
            field.Save();
        }

        private void зановоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DGV.Enabled = true;
            field.Read();
            time = new TimeSpan(0,0,1);
            timer1.Start();
            n = 0;
            Start_Game();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            field.Save();
            timer1.Stop();
            this.Close();
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            n++;
            label2.Text = "Количество ходов : " + n.ToString();
            field.ChangePosition(e.RowIndex, e.ColumnIndex);
            Start_Game();
        }
    };
}
