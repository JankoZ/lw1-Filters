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
        private int matirxSize;

        public ChangeStruct()
        {
            InitializeComponent();
        }

        public ChangeStruct(int size)
        {
            InitializeComponent();
            matirxSize = size;
            switch (size)
            {
                case 1: numericUpDown2.Visible = false; numericUpDown3.Visible = false; numericUpDown4.Visible = false; numericUpDown5.Visible = false; numericUpDown6.Visible = false; numericUpDown7.Visible = false; numericUpDown8.Visible = false; numericUpDown9.Visible = false; numericUpDown10.Visible = false; numericUpDown11.Visible = false; numericUpDown12.Visible = false; numericUpDown13.Visible = false; numericUpDown14.Visible = false; numericUpDown15.Visible = false; numericUpDown16.Visible = false; numericUpDown17.Visible = false; numericUpDown18.Visible = false; numericUpDown19.Visible = false; numericUpDown20.Visible = false; numericUpDown21.Visible = false; numericUpDown22.Visible = false; numericUpDown23.Visible = false; numericUpDown24.Visible = false; numericUpDown25.Visible = false; break;
                case 2: numericUpDown3.Visible = false; numericUpDown4.Visible = false; numericUpDown5.Visible = false; numericUpDown8.Visible = false; numericUpDown9.Visible = false; numericUpDown10.Visible = false; numericUpDown11.Visible = false; numericUpDown12.Visible = false; numericUpDown13.Visible = false; numericUpDown14.Visible = false; numericUpDown15.Visible = false; numericUpDown16.Visible = false; numericUpDown17.Visible = false; numericUpDown18.Visible = false; numericUpDown19.Visible = false; numericUpDown20.Visible = false; numericUpDown21.Visible = false; numericUpDown22.Visible = false; numericUpDown23.Visible = false; numericUpDown24.Visible = false; numericUpDown25.Visible = false; break;
                case 3: numericUpDown4.Visible = false; numericUpDown5.Visible = false; numericUpDown9.Visible = false; numericUpDown10.Visible = false; numericUpDown14.Visible = false; numericUpDown15.Visible = false; numericUpDown16.Visible = false; numericUpDown17.Visible = false; numericUpDown18.Visible = false; numericUpDown19.Visible = false; numericUpDown20.Visible = false; numericUpDown21.Visible = false; numericUpDown22.Visible = false; numericUpDown23.Visible = false; numericUpDown24.Visible = false; numericUpDown25.Visible = false; break;
                case 4: numericUpDown5.Visible = false; numericUpDown10.Visible = false; numericUpDown15.Visible = false; numericUpDown20.Visible = false; numericUpDown21.Visible = false; numericUpDown22.Visible = false; numericUpDown23.Visible = false; numericUpDown24.Visible = false; numericUpDown25.Visible = false; break;
            }
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
            switch (matirxSize)
            {
                case 1: kernel = new float[1, 1] { { (float)numericUpDown1.Value } }; break;
                case 2: kernel = new float[2, 2] { { (float)numericUpDown1.Value, (float)numericUpDown2.Value }, { (float)numericUpDown6.Value, (float)numericUpDown7.Value } }; break;
                case 3: kernel = new float[3, 3] { { (float)numericUpDown1.Value, (float)numericUpDown2.Value, (float)numericUpDown3.Value }, { (float)numericUpDown6.Value, (float)numericUpDown7.Value, (float)numericUpDown8.Value }, { (float)numericUpDown11.Value, (float)numericUpDown12.Value, (float)numericUpDown13.Value } }; break;
                case 4: kernel = new float[4, 4] { { (float)numericUpDown1.Value, (float)numericUpDown2.Value, (float)numericUpDown3.Value, (float)numericUpDown4.Value }, { (float)numericUpDown6.Value, (float)numericUpDown7.Value, (float)numericUpDown8.Value, (float)numericUpDown9.Value }, { (float)numericUpDown11.Value, (float)numericUpDown12.Value, (float)numericUpDown13.Value, (float)numericUpDown14.Value }, { (float)numericUpDown16.Value, (float)numericUpDown17.Value, (float)numericUpDown18.Value, (float)numericUpDown19.Value } }; break;
                case 5: kernel = new float[5, 5] { { (float)numericUpDown1.Value, (float)numericUpDown2.Value, (float)numericUpDown3.Value, (float)numericUpDown4.Value, (float)numericUpDown5.Value }, { (float)numericUpDown6.Value, (float)numericUpDown7.Value, (float)numericUpDown8.Value, (float)numericUpDown9.Value, (float)numericUpDown10.Value }, { (float)numericUpDown11.Value, (float)numericUpDown12.Value, (float)numericUpDown13.Value, (float)numericUpDown14.Value, (float)numericUpDown15.Value }, { (float)numericUpDown16.Value, (float)numericUpDown17.Value, (float)numericUpDown18.Value, (float)numericUpDown19.Value, (float)numericUpDown20.Value }, { (float)numericUpDown21.Value, (float)numericUpDown22.Value, (float)numericUpDown23.Value, (float)numericUpDown24.Value, (float)numericUpDown25.Value } }; break;
            }
            Form1.gKernel = kernel;
            Close();
        }
    }
}