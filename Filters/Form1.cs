using System.Diagnostics;
using System.IO;
using System.Runtime.Intrinsics.X86;
using static System.Net.WebRequestMethods;

namespace Filters
{
    public partial class Form1 : Form
    {
        Bitmap image;
        Stack<Bitmap> images = new Stack<Bitmap>();
        public static float[,] gKernel = new float[3, 3] { { 0, 1, 0 }, { 1, 0, 1 }, { 0, 1, 0 } };
        public static Color dstColor = Color.White, srcColor = Color.White;

        public Form1()
        {
            InitializeComponent();
        }

        private void îòêðûòüToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            Bitmap newImage = ((Filters)e.Argument).processImage(image, backgroundWorker1);
            if (backgroundWorker1.CancellationPending != true)
            {
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

        private void âûéòèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ñîõðàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (image != null)
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.AddExtension = true;
                dialog.Filter = "Portable Network Graphics (*.png)|*.png|Joint Photographic Experts Group (*.jpg)|*.jpg|Bitmap Picture (*.bmp)|*.bmp|All Files (*.*)|*.*";
                dialog.FilterIndex = 1;
                dialog.FileName = "Image";
                dialog.OverwritePrompt = true;

                if (dialog.ShowDialog() == DialogResult.OK) pictureBox1.Image.Save(dialog.FileName);
            }
            else MessageBox.Show("Íåâîçìîæíî ñîõðàíèòü!", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (images.Count > 0)
            {
                image = images.Pop();
                pictureBox1.Image = image;
                pictureBox1.Refresh();
            }
            else MessageBox.Show("Íåâîçìîæíî îòìåíèòü äåéñòâèå!", "Îøèáêà", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #region Filters
        private void âîëíûToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new WavesFilter();
            images.Push(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïåðåíîñToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MovingFilter();
            images.Push(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïîâîðîòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new RotateFilter();
            images.Push(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ñäåëàòü×åðíîáåëûìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter();
            images.Push(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ñåïèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SepiaFilter();
            images.Push(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïîâûñèòü_ÿðêîñòütoolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BrightnessFilter();
            images.Push(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïîYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelFilter('Y');
            images.Push(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïîXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SobelFilter('X');
            images.Push(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void èçìåíåíèåÐåçêîñòèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new SharpnessFilter();
            images.Push(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïîXToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new EdgeDetectionFilter(0, 'X');
            images.Push(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïîYToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Filters filter = new EdgeDetectionFilter(0, 'Y');
            images.Push(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïîXToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Filters filter = new EdgeDetectionFilter(1, 'X');
            images.Push(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïîYToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Filters filter = new EdgeDetectionFilter(1, 'Y');
            images.Push(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void òèñíåíèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GrayScaleFilter();
            images.Push(image);
            image = filter.processImage(image);
            filter = new EmbossingFilter();
            image = filter.processImage(image);
            filter = new NormalizationFilter();
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ðàçìûòèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BlurFilter();
            images.Push(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ïîÃàóññóToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GaussianFilter();
            images.Push(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void èíâåðñèÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new InvertFilter();
            images.Push(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ýôôåêòñòåêëàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new GlassFilter();
            images.Push(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ðàçìûòèåÂÄâèæåíèèToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MotionBlurFilter(3);
            images.Push(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ñåðûéÌèðToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrayWorldFilter grayWorldFilter = new GrayWorldFilter();
            images.Push(image);
            double n = image.Height * image.Width, rSum = 0, gSum = 0, bSum = 0;
            for (int i = 0; i != image.Width; i++)
                for (int j = 0; j != image.Height; j++)
                {
                    rSum += image.GetPixel(i, j).R;
                    gSum += image.GetPixel(i, j).G;
                    bSum += image.GetPixel(i, j).B;
                }

            grayWorldFilter.rAvg = (1 / n) * rSum;
            grayWorldFilter.gAvg = (1 / n) * gSum;
            grayWorldFilter.bAvg = (1 / n) * bSum;
            grayWorldFilter.avg = (grayWorldFilter.rAvg + grayWorldFilter.gAvg + grayWorldFilter.bAvg) / 3;

            backgroundWorker1.RunWorkerAsync(grayWorldFilter);
        }

        private void ëèíåéíîåÐàñòÿæåíèåÃèñòîãðàììûToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LinearHistogramStretchFilter filter = new LinearHistogramStretchFilter();
            images.Push(image);

            for (int i = 0; i != image.Width; i++)
                for (int j = 0; j != image.Height; j++)
                {
                    float brightness = image.GetPixel(i, j).GetBrightness();
                    if (filter.fMin > brightness) filter.fMin = brightness;
                    if (filter.fMax < brightness) filter.fMax = brightness;
                }

            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ìåäèàííûéÔèëüòðToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedianFilter filter = new MedianFilter();
            images.Push(image);
            filter.radius = 3;
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ðàñøèðåíèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MorphologyDilation(gKernel);
            images.Push(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ñóæåíèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MorphologyErosion(gKernel);
            images.Push(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void îòêðûòèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MorphologyErosion(gKernel);
            images.Push(image);
            image = filter.processImage(image);
            filter = new MorphologyDilation(gKernel);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void çàêðûòèåToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MorphologyDilation(gKernel);
            images.Push(image);
            image = filter.processImage(image);
            filter = new MorphologyErosion(gKernel);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void gradToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MorphologyDilation(gKernel);
            Bitmap tmp = image;
            images.Push(image);
            image = filter.processImage(image);

            filter = new MorphologyErosion(gKernel);
            tmp = filter.processImage(tmp);

            filter = new MorphologyGrad(image, tmp);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void ñâåòÿùèåñÿÊðàÿToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MedianFilter mfilter = new MedianFilter();
            images.Push(image);
            mfilter.radius = 1;
            image = mfilter.processImage(image);

            SobelFilter sfilter = new SobelFilter('X');
            image = sfilter.processImage(image);

            MaximumFilter filter = new MaximumFilter();
            filter.radius = 1;
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void èäåàëüíûéÎòðàæàòåëüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PerfectReflectorFilter filter = new PerfectReflectorFilter();
            images.Push(image);
            for (int i = 0; i != image.Width; i++)
                for (int j = 0; j != image.Height; j++)
                {
                    if (filter.rMax < image.GetPixel(i, j).R) filter.rMax = image.GetPixel(i, j).R;
                    if (filter.gMax < image.GetPixel(i, j).G) filter.gMax = image.GetPixel(i, j).G;
                    if (filter.bMax < image.GetPixel(i, j).B) filter.bMax = image.GetPixel(i, j).B;
                }

            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void topHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new BrightnessFilter();
            images.Push(image);
            image = filter.processImage(image);
            filter = new AntiBrightnessFilter();
            image = filter.processImage(image);

            filter = new MorphologyDilation(gKernel);
            Bitmap tmp;
            tmp = filter.processImage(image);
            filter = new MorphologyErosion(gKernel);
            tmp = filter.processImage(tmp);

            filter = new MorphologyGrad(image, tmp);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void blackHatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Filters filter = new MorphologyErosion(gKernel);
            Bitmap tmp = image;
            images.Push(image);
            image = filter.processImage(image);
            filter = new MorphologyDilation(gKernel);
            image = filter.processImage(image);

            filter = new MorphologyGrad(image, tmp);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void íàñòðîèòüÑòðóêòóðíûéÝëåìåíòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangeStruct changeStruct = new ChangeStruct();
            changeStruct.Show();
        }

        private void êîððåêöèÿÑÎïîðíûìÖâåòîìToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReferenceColorCorrectionFilter filter = new ReferenceColorCorrectionFilter();
            images.Push(image);
            backgroundWorker1.RunWorkerAsync(filter);
        }

        private void íàñòðîèòüÎïîðíûéÖâåòToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReferenceColorCorrection form = new ReferenceColorCorrection();
            form.image = image;
            form.Show();
        }
        #endregion
    }
}