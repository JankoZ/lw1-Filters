using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filters
{
    public partial class ChangeStruct : Form
    {
        public float[,] kernel;

        public ChangeStruct()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kernel = new float[3, 3] { { 0, 1, 0 }, { 1, 0, 1 }, { 0, 1, 0 } };
            Form1.gKernel = kernel;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == null && textBox10.Text == null && textBox15.Text == null && textBox20.Text == null && textBox25.Text == null && textBox21.Text == null && textBox22.Text == null && textBox23.Text == null && textBox24.Text == null)
            {
                kernel = new float[4, 4];
                SetCell(textBox1, 0, 0); SetCell(textBox2, 0, 1); SetCell(textBox3, 0, 2); SetCell(textBox4, 0, 3);
                SetCell(textBox6, 1, 0); SetCell(textBox7, 1, 1); SetCell(textBox8, 1, 2); SetCell(textBox9, 1, 3);
                SetCell(textBox11, 2, 0); SetCell(textBox12, 2, 1); SetCell(textBox13, 2, 2); SetCell(textBox14, 2, 3);
                SetCell(textBox16, 3, 0); SetCell(textBox17, 3, 1); SetCell(textBox18, 3, 2); SetCell(textBox19, 3, 3);
            }
            else if (textBox4.Text == null && textBox9.Text == null && textBox14.Text == null && textBox16.Text == null && textBox17.Text == null && textBox18.Text == null && textBox19.Text == null)
            {
                kernel = new float[3, 3];
                SetCell(textBox1, 0, 0); SetCell(textBox2, 0, 1); SetCell(textBox3, 0, 2);
                SetCell(textBox6, 1, 0); SetCell(textBox7, 1, 1); SetCell(textBox8, 1, 2);
                SetCell(textBox11, 2, 0); SetCell(textBox12, 2, 1); SetCell(textBox13, 2, 2);
            }
            else if (textBox3.Text == null && textBox8.Text == null && textBox11.Text == null && textBox12.Text == null && textBox13.Text == null)
            {
                kernel = new float[2, 2];
                SetCell(textBox1, 0, 0); SetCell(textBox2, 0, 1);
                SetCell(textBox6, 1, 0); SetCell(textBox7, 1, 1);
            }
            else
            {
                kernel = new float[5, 5];
                SetCell(textBox1, 0, 0); SetCell(textBox2, 0, 1); SetCell(textBox3, 0, 2); SetCell(textBox4, 0, 3); SetCell(textBox5, 0, 4);
                SetCell(textBox6, 1, 0); SetCell(textBox7, 1, 1); SetCell(textBox8, 1, 2); SetCell(textBox9, 1, 3); SetCell(textBox10, 1, 4);
                SetCell(textBox11, 2, 0); SetCell(textBox12, 2, 1); SetCell(textBox13, 2, 2); SetCell(textBox14, 2, 3); SetCell(textBox15, 2, 4);
                SetCell(textBox16, 3, 0); SetCell(textBox17, 3, 1); SetCell(textBox18, 3, 2); SetCell(textBox19, 3, 3); SetCell(textBox20, 3, 4);
                SetCell(textBox21, 4, 0); SetCell(textBox22, 4, 1); SetCell(textBox23, 4, 2); SetCell(textBox24, 4, 3); SetCell(textBox25, 4, 4);
            }
            Form1.gKernel = kernel;
            Close();
        }

        private void SetCell(TextBox textBox, int i, int j)
        {
            if (textBox.Text == "1") kernel[i, j] = 1;
            else kernel[i, j] = 0;
        }
    }
}