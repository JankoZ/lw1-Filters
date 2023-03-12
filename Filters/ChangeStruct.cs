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
                case 1: kernel = new float[1, 1] { { (int)numericUpDown1.Value } }; break;
                case 2: kernel = new float[2, 2] { { (int)numericUpDown1.Value, (int)numericUpDown2.Value }, { (int)numericUpDown6.Value, (int)numericUpDown7.Value } }; break;
                case 3: kernel = new float[3, 3] { { (int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value }, { (int)numericUpDown6.Value, (int)numericUpDown7.Value, (int)numericUpDown8.Value }, { (int)numericUpDown11.Value, (int)numericUpDown12.Value, (int)numericUpDown13.Value } }; break;
                case 4: kernel = new float[4, 4] { { (int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value, (int)numericUpDown4.Value }, { (int)numericUpDown6.Value, (int)numericUpDown7.Value, (int)numericUpDown8.Value, (int)numericUpDown9.Value }, { (int)numericUpDown11.Value, (int)numericUpDown12.Value, (int)numericUpDown13.Value, (int)numericUpDown14.Value }, { (int)numericUpDown16.Value, (int)numericUpDown17.Value, (int)numericUpDown18.Value, (int)numericUpDown19.Value } }; break;
                case 5: kernel = new float[5, 5] { { (int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value, (int)numericUpDown4.Value, (int)numericUpDown5.Value }, { (int)numericUpDown6.Value, (int)numericUpDown7.Value, (int)numericUpDown8.Value, (int)numericUpDown9.Value, (int)numericUpDown10.Value }, { (int)numericUpDown11.Value, (int)numericUpDown12.Value, (int)numericUpDown13.Value, (int)numericUpDown14.Value, (int)numericUpDown15.Value }, { (int)numericUpDown16.Value, (int)numericUpDown17.Value, (int)numericUpDown18.Value, (int)numericUpDown19.Value, (int)numericUpDown20.Value }, { (int)numericUpDown21.Value, (int)numericUpDown22.Value, (int)numericUpDown23.Value, (int)numericUpDown24.Value, (int)numericUpDown25.Value } }; break;
            }
            Form1.gKernel = kernel;
            Close();
        }
    }
}