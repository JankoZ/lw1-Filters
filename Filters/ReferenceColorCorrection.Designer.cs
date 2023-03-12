namespace Filters
{
    partial class ReferenceColorCorrection
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
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(143, 20);
            label1.TabIndex = 0;
            label1.Text = "Исходный пиксель:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(170, 17);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(57, 27);
            textBox1.TabIndex = 1;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 20);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 2;
            label2.Text = ": W.";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(272, 17);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(57, 27);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(335, 20);
            label3.Name = "label3";
            label3.Size = new Size(30, 20);
            label3.TabIndex = 4;
            label3.Text = ": H.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 71);
            label4.Name = "label4";
            label4.Size = new Size(133, 20);
            label4.TabIndex = 5;
            label4.Text = "Целевой пиксель:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(159, 68);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(46, 27);
            textBox3.TabIndex = 6;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(211, 71);
            label5.Name = "label5";
            label5.Size = new Size(18, 20);
            label5.TabIndex = 7;
            label5.Text = "R";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(235, 68);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(46, 27);
            textBox4.TabIndex = 8;
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(287, 71);
            label6.Name = "label6";
            label6.Size = new Size(19, 20);
            label6.TabIndex = 9;
            label6.Text = "G";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(312, 68);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(46, 27);
            textBox5.TabIndex = 10;
            textBox5.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(364, 71);
            label7.Name = "label7";
            label7.Size = new Size(18, 20);
            label7.TabIndex = 11;
            label7.Text = "B";
            // 
            // button1
            // 
            button1.Location = new Point(20, 118);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 12;
            button1.Text = "Применить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(272, 118);
            button2.Name = "button2";
            button2.Size = new Size(100, 30);
            button2.TabIndex = 13;
            button2.Text = "Отмена";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // ReferenceColorCorrection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 163);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReferenceColorCorrection";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Коррекция с опорным цветом";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private Button button1;
        private Button button2;
    }
}