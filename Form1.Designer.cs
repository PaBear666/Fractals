namespace WindowsFormsApp1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.length = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.angle = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.line_length = new System.Windows.Forms.TextBox();
            this.Default_Values = new System.Windows.Forms.Button();
            this.DrawPicture = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Bourbon Grotesque", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Кто выполнил";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bourbon Grotesque", 12F);
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Бурмистров Никита \r\n6203\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.Default_Values);
            this.groupBox2.Font = new System.Drawing.Font("Bourbon Grotesque", 12F);
            this.groupBox2.Location = new System.Drawing.Point(3, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 422);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.length);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 146);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(171, 77);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Кол-во шагов";
            // 
            // length
            // 
            this.length.Location = new System.Drawing.Point(10, 28);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(157, 29);
            this.length.TabIndex = 0;
            this.length.Text = "6";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.angle);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(0, 257);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(171, 72);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Угол поворота";
            // 
            // angle
            // 
            this.angle.Location = new System.Drawing.Point(10, 28);
            this.angle.Name = "angle";
            this.angle.Size = new System.Drawing.Size(157, 29);
            this.angle.TabIndex = 0;
            this.angle.Text = "20";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.line_length);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(171, 72);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Длина ветви";
            // 
            // line_length
            // 
            this.line_length.Location = new System.Drawing.Point(6, 28);
            this.line_length.Name = "line_length";
            this.line_length.Size = new System.Drawing.Size(161, 29);
            this.line_length.TabIndex = 0;
            this.line_length.Text = "10";
            // 
            // Default_Values
            // 
            this.Default_Values.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Default_Values.Location = new System.Drawing.Point(0, 371);
            this.Default_Values.Name = "Default_Values";
            this.Default_Values.Size = new System.Drawing.Size(177, 45);
            this.Default_Values.TabIndex = 0;
            this.Default_Values.Text = "Значения по \r\nзаданию";
            this.Default_Values.UseVisualStyleBackColor = true;
            this.Default_Values.Click += new System.EventHandler(this.Default_Values_Click);
            // 
            // DrawPicture
            // 
            this.DrawPicture.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DrawPicture.Location = new System.Drawing.Point(3, 577);
            this.DrawPicture.Name = "DrawPicture";
            this.DrawPicture.Size = new System.Drawing.Size(177, 91);
            this.DrawPicture.TabIndex = 3;
            this.DrawPicture.Text = "Построить";
            this.DrawPicture.UseVisualStyleBackColor = true;
            this.DrawPicture.Click += new System.EventHandler(this.DrawPicture_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(203, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 645);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1361, 680);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DrawPicture);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Fractals";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox line_length;
        private System.Windows.Forms.Button DrawPicture;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button Default_Values;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox length;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox angle;
        private System.Windows.Forms.Panel panel1;
    }
}

