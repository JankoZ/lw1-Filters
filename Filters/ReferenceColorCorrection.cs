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
    public partial class ReferenceColorCorrection : Form
    {
        public Bitmap image;

        public ReferenceColorCorrection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox2.Text != null) Form1.srcColor = image.GetPixel(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            if (textBox3.Text != null && textBox4.Text != null && textBox5.Text != null)
                Form1.dstColor = Color.FromArgb(int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text));
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
