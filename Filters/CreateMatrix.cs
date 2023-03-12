using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Filters
{
    public partial class CreateMatrix : Form
    {
        public CreateMatrix()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeStruct form = new ChangeStruct((int)numericUpDown1.Value);
            form.Show();
            Close();
        }
    }
}
