namespace ты_дурак
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
            this.button_yes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_no = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_yes
            // 
            this.button_yes.AccessibleName = "";
            this.button_yes.BackColor = System.Drawing.Color.SpringGreen;
            this.button_yes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_yes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.button_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_yes.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_yes.Location = new System.Drawing.Point(94, 187);
            this.button_yes.Name = "button_yes";
            this.button_yes.Size = new System.Drawing.Size(110, 56);
            this.button_yes.TabIndex = 0;
            this.button_yes.Text = "Да";
            this.button_yes.UseVisualStyleBackColor = false;
            this.button_yes.Click += new System.EventHandler(this.button_yes_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 63);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ты дурак?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(193, 397);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 26);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.HotPink;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(194, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cheat-код";
            // 
            // button_no
            // 
            this.button_no.BackColor = System.Drawing.Color.Tomato;
            this.button_no.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_no.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.button_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_no.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_no.Location = new System.Drawing.Point(346, 187);
            this.button_no.Name = "button_no";
            this.button_no.Size = new System.Drawing.Size(119, 56);
            this.button_no.TabIndex = 4;
            this.button_no.Text = "Нет";
            this.button_no.UseVisualStyleBackColor = false;
            this.button_no.Click += new System.EventHandler(this.button_no_Click);
            this.button_no.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button_no_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(567, 476);
            this.Controls.Add(this.button_no);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_yes);
            this.Name = "Form1";
            this.Text = "Ты дурак?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_yes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_no;
    }
}

