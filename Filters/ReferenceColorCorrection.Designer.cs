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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            numericUpDown4 = new NumericUpDown();
            numericUpDown5 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 20);
            label2.Name = "label2";
            label2.Size = new Size(33, 20);
            label2.TabIndex = 2;
            label2.Text = ": W.";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(224, 71);
            label5.Name = "label5";
            label5.Size = new Size(18, 20);
            label5.TabIndex = 7;
            label5.Text = "R";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(313, 71);
            label6.Name = "label6";
            label6.Size = new Size(19, 20);
            label6.TabIndex = 9;
            label6.Text = "G";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(403, 71);
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
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(170, 20);
            numericUpDown1.Maximum = new decimal(new int[] { 32767, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(59, 27);
            numericUpDown1.TabIndex = 14;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown2.Location = new Point(270, 20);
            numericUpDown2.Maximum = new decimal(new int[] { 32767, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(59, 27);
            numericUpDown2.TabIndex = 15;
            numericUpDown2.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown3.Location = new Point(159, 71);
            numericUpDown3.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(59, 27);
            numericUpDown3.TabIndex = 16;
            numericUpDown3.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown4
            // 
            numericUpDown4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown4.Location = new Point(248, 71);
            numericUpDown4.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(59, 27);
            numericUpDown4.TabIndex = 17;
            numericUpDown4.TextAlign = HorizontalAlignment.Center;
            // 
            // numericUpDown5
            // 
            numericUpDown5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown5.Location = new Point(338, 71);
            numericUpDown5.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(59, 27);
            numericUpDown5.TabIndex = 18;
            numericUpDown5.TextAlign = HorizontalAlignment.Center;
            // 
            // ReferenceColorCorrection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 163);
            Controls.Add(numericUpDown5);
            Controls.Add(numericUpDown4);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReferenceColorCorrection";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Коррекция с опорным цветом";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button button2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown5;
    }
}