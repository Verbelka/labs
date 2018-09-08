namespace мишень
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.target = new System.Windows.Forms.Panel();
            this.buttonShoot = new System.Windows.Forms.Button();
            this.textBoxR = new System.Windows.Forms.TextBox();
            this.labelR = new System.Windows.Forms.Label();
            this.labelShoot = new System.Windows.Forms.Label();
            this.textBoxShoot = new System.Windows.Forms.TextBox();
            this.labelCoord = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelYes = new System.Windows.Forms.Label();
            this.labelYesS = new System.Windows.Forms.Label();
            this.labelNo = new System.Windows.Forms.Label();
            this.labelNoS = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelLeft = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // target
            // 
            this.target.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.target.Location = new System.Drawing.Point(63, 122);
            this.target.Name = "target";
            this.target.Size = new System.Drawing.Size(603, 537);
            this.target.TabIndex = 0;
            // 
            // buttonShoot
            // 
            this.buttonShoot.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonShoot.Enabled = false;
            this.buttonShoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShoot.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShoot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonShoot.Location = new System.Drawing.Point(746, 594);
            this.buttonShoot.Name = "buttonShoot";
            this.buttonShoot.Size = new System.Drawing.Size(151, 65);
            this.buttonShoot.TabIndex = 1;
            this.buttonShoot.Text = "Выстрел!";
            this.buttonShoot.UseVisualStyleBackColor = false;
            this.buttonShoot.Click += new System.EventHandler(this.buttonShoot_Click);
            // 
            // textBoxR
            // 
            this.textBoxR.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxR.Location = new System.Drawing.Point(291, 26);
            this.textBoxR.Name = "textBoxR";
            this.textBoxR.Size = new System.Drawing.Size(87, 26);
            this.textBoxR.TabIndex = 2;
            // 
            // labelR
            // 
            this.labelR.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelR.Location = new System.Drawing.Point(57, 20);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(202, 34);
            this.labelR.TabIndex = 3;
            this.labelR.Text = "Введите радиус:";
            // 
            // labelShoot
            // 
            this.labelShoot.AutoSize = true;
            this.labelShoot.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelShoot.Location = new System.Drawing.Point(57, 64);
            this.labelShoot.Name = "labelShoot";
            this.labelShoot.Size = new System.Drawing.Size(355, 35);
            this.labelShoot.TabIndex = 4;
            this.labelShoot.Text = "Введите количество выстрелов:";
            // 
            // textBoxShoot
            // 
            this.textBoxShoot.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxShoot.Location = new System.Drawing.Point(454, 70);
            this.textBoxShoot.Name = "textBoxShoot";
            this.textBoxShoot.Size = new System.Drawing.Size(90, 26);
            this.textBoxShoot.TabIndex = 5;
            // 
            // labelCoord
            // 
            this.labelCoord.AutoSize = true;
            this.labelCoord.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.labelCoord.Location = new System.Drawing.Point(740, 226);
            this.labelCoord.Name = "labelCoord";
            this.labelCoord.Size = new System.Drawing.Size(157, 35);
            this.labelCoord.TabIndex = 6;
            this.labelCoord.Text = "Координаты:";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.labelX.Location = new System.Drawing.Point(695, 291);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(36, 35);
            this.labelX.TabIndex = 7;
            this.labelX.Text = "Х:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.labelY.Location = new System.Drawing.Point(697, 353);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(34, 35);
            this.labelY.TabIndex = 9;
            this.labelY.Text = "Y:";
            // 
            // labelYes
            // 
            this.labelYes.AutoSize = true;
            this.labelYes.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.labelYes.Location = new System.Drawing.Point(689, 493);
            this.labelYes.Name = "labelYes";
            this.labelYes.Size = new System.Drawing.Size(130, 35);
            this.labelYes.TabIndex = 11;
            this.labelYes.Text = "Попадания:";
            // 
            // labelYesS
            // 
            this.labelYesS.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelYesS.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.labelYesS.Location = new System.Drawing.Point(834, 493);
            this.labelYesS.Name = "labelYesS";
            this.labelYesS.Size = new System.Drawing.Size(100, 31);
            this.labelYesS.TabIndex = 12;
            this.labelYesS.Text = "0";
            // 
            // labelNo
            // 
            this.labelNo.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.labelNo.Location = new System.Drawing.Point(689, 538);
            this.labelNo.Name = "labelNo";
            this.labelNo.Size = new System.Drawing.Size(124, 41);
            this.labelNo.TabIndex = 13;
            this.labelNo.Text = "Промахи:";
            // 
            // labelNoS
            // 
            this.labelNoS.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNoS.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.labelNoS.Location = new System.Drawing.Point(834, 538);
            this.labelNoS.Name = "labelNoS";
            this.labelNoS.Size = new System.Drawing.Size(100, 35);
            this.labelNoS.TabIndex = 14;
            this.labelNoS.Text = "0";
            // 
            // textBoxX
            // 
            this.textBoxX.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxX.Enabled = false;
            this.textBoxX.Location = new System.Drawing.Point(746, 300);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(90, 26);
            this.textBoxX.TabIndex = 15;
            // 
            // textBoxY
            // 
            this.textBoxY.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxY.Enabled = false;
            this.textBoxY.Location = new System.Drawing.Point(746, 359);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(90, 26);
            this.textBoxY.TabIndex = 16;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Turquoise;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(746, 37);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(151, 59);
            this.buttonStart.TabIndex = 17;
            this.buttonStart.Text = "Начать";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelLeft
            // 
            this.labelLeft.AutoSize = true;
            this.labelLeft.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLeft.Location = new System.Drawing.Point(695, 429);
            this.labelLeft.Name = "labelLeft";
            this.labelLeft.Size = new System.Drawing.Size(125, 35);
            this.labelLeft.TabIndex = 18;
            this.labelLeft.Text = "Осталось:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(840, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 31);
            this.label1.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Turquoise;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(746, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 64);
            this.button1.TabIndex = 20;
            this.button1.Text = "Заново";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 692);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLeft);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.labelNoS);
            this.Controls.Add(this.labelNo);
            this.Controls.Add(this.labelYesS);
            this.Controls.Add(this.labelYes);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.labelCoord);
            this.Controls.Add(this.textBoxShoot);
            this.Controls.Add(this.labelShoot);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.textBoxR);
            this.Controls.Add(this.buttonShoot);
            this.Controls.Add(this.target);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Мишень";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel target;
        private System.Windows.Forms.Button buttonShoot;
        private System.Windows.Forms.TextBox textBoxR;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelShoot;
        private System.Windows.Forms.TextBox textBoxShoot;
        private System.Windows.Forms.Label labelCoord;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelYes;
        private System.Windows.Forms.Label labelYesS;
        private System.Windows.Forms.Label labelNo;
        private System.Windows.Forms.Label labelNoS;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

