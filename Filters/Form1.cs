using System.Diagnostics;
using System.IO;

namespace Filters
{
    public partial class Form1 : Form
    {
        Bitmap image;
        List<Bitmap> images = new List<Bitmap>();

        public Form1()
        {
            InitializeComponent();
        }

        private void îòêğûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files | *.png; *.jpg; *.bmp | All Files (*.*) | *.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(dialog.FileName);
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
        }

        private void èíâåğñèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvertFilter filter = new InvertFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
            {
                images.Add(image);
                image = newImage;
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (!e.Cancelled)
            {
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            progressBar1.Value = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.CancelAsync();
        }

        private void ğàçìûòèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BlurFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïîÃàóññóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GaussianFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void âûéòèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ñäåëàòü×åğíîáåëûìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ñåïèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SepiaFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïîâûñèòü_ÿğêîñòütoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BrightnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïîYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelFilter('Y');
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïîXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelFilter('X');
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void èçìåíåíèåĞåçêîñòèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SharpnessFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïîXToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new EdgeDetectionFilter(0, 'X');
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïîYToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new EdgeDetectionFilter(0, 'Y');
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïîXToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Filters filter = new EdgeDetectionFilter(1, 'X');
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïîYToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Filters filter = new EdgeDetectionFilter(1, 'Y');
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void òèñíåíèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter();
            Bitmap resultImage = new Bitmap(image);
            FilterApply(filter, resultImage);
            filter = new EmbossingFilter();
            FilterApply(filter, resultImage);
            filter = new NormalizationFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ñîõğàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.AddExtension = true;
            dialog.Filter = "Portable Network Graphics (*.png)|*.png|Joint Photographic Experts Group (*.jpg)|*.jpg|Bitmap Picture (*.bmp)|*.bmp|All Files (*.*)|*.*";
            dialog.FilterIndex = 1;
            dialog.FileName = "Image";
            dialog.OverwritePrompt = true;

            if (dialog.ShowDialog() == DialogResult.OK) pictureBox1.Image.Save(dialog.FileName);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (images.Count > 0)
            {
                pictureBox1.Image = images[images.Count - 1];
                pictureBox1.Refresh();
                images.Remove(images[images.Count - 1]);
            }
            else MessageBox.Show("Íåâîçìîæíî îòìåíèòü äåéñòâèå!", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void FilterApply(Filters filter, Bitmap resultImage)
        {
            resultImage = filter.processImage(image, backgroundWorker1);
            images.Add(image);
            image = resultImage;
            pictureBox1.Image = resultImage;
            pictureBox1.Refresh();
        }
    }
}