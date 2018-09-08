namespace Eventss
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
            textBox1 = new System.Windows.Forms.RichTextBox();
            this.StartB = new System.Windows.Forms.Button();
            this.FinishB = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = System.Drawing.SystemColors.Info;
            textBox1.Location = new System.Drawing.Point(27, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new System.Drawing.Size(571, 422);
            textBox1.TabIndex = 0;
            textBox1.Text = "";
            textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // StartB
            // 
            this.StartB.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.StartB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartB.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.StartB.Location = new System.Drawing.Point(442, 461);
            this.StartB.Name = "StartB";
            this.StartB.Size = new System.Drawing.Size(156, 40);
            this.StartB.TabIndex = 1;
            this.StartB.Text = "Start";
            this.StartB.UseVisualStyleBackColor = true;
            this.StartB.Click += new System.EventHandler(this.StartB_Click);
            // 
            // FinishB
            // 
            this.FinishB.Enabled = false;
            this.FinishB.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.FinishB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinishB.Location = new System.Drawing.Point(192, 461);
            this.FinishB.Name = "FinishB";
            this.FinishB.Size = new System.Drawing.Size(118, 40);
            this.FinishB.TabIndex = 2;
            this.FinishB.Text = "Finish";
            this.FinishB.UseVisualStyleBackColor = true;
            this.FinishB.Click += new System.EventHandler(this.FinishB_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(27, 461);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 40);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "1000";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            panel1.Location = new System.Drawing.Point(635, 12);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(621, 422);
            panel1.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1157, 461);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(99, 40);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "1000";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(667, 463);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(84, 40);
            this.textBox4.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(630, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 40);
            this.label1.TabIndex = 7;
            this.label1.Text = "Х:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(757, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 40);
            this.label2.TabIndex = 8;
            this.label2.Text = "Y:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(787, 463);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(84, 40);
            this.textBox5.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(886, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 40);
            this.label3.TabIndex = 10;
            this.label3.Text = "R:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(917, 463);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(84, 40);
            this.textBox6.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1024, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 40);
            this.button1.TabIndex = 12;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(panel1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.FinishB);
            this.Controls.Add(this.StartB);
            this.Controls.Add(textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Events";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button StartB;
        private System.Windows.Forms.Button FinishB;
        private System.Windows.Forms.TextBox textBox2;
        private static System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        public static System.Windows.Forms.RichTextBox textBox1;
    }
}

