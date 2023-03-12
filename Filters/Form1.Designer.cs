namespace Filters
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            выйтиToolStripMenuItem = new ToolStripMenuItem();
            фильтрыToolStripMenuItem = new ToolStripMenuItem();
            точечныеToolStripMenuItem = new ToolStripMenuItem();
            волныToolStripMenuItem = new ToolStripMenuItem();
            инверсияToolStripMenuItem = new ToolStripMenuItem();
            переносToolStripMenuItem = new ToolStripMenuItem();
            поворотToolStripMenuItem = new ToolStripMenuItem();
            повысить_яркостьtoolStripMenuItem = new ToolStripMenuItem();
            сделатьЧернобелымToolStripMenuItem = new ToolStripMenuItem();
            сепияToolStripMenuItem = new ToolStripMenuItem();
            эффектстеклаToolStripMenuItem = new ToolStripMenuItem();
            матричныеToolStripMenuItem = new ToolStripMenuItem();
            выделениеГраницToolStripMenuItem = new ToolStripMenuItem();
            операторПрюиттаToolStripMenuItem = new ToolStripMenuItem();
            поXToolStripMenuItem2 = new ToolStripMenuItem();
            поYToolStripMenuItem2 = new ToolStripMenuItem();
            операторЩарраToolStripMenuItem = new ToolStripMenuItem();
            поXToolStripMenuItem1 = new ToolStripMenuItem();
            поYToolStripMenuItem1 = new ToolStripMenuItem();
            изменениеРезкостиToolStripMenuItem = new ToolStripMenuItem();
            медианныйФильтрToolStripMenuItem = new ToolStripMenuItem();
            операторСобеляToolStripMenuItem = new ToolStripMenuItem();
            поXToolStripMenuItem = new ToolStripMenuItem();
            поYToolStripMenuItem = new ToolStripMenuItem();
            поГауссуToolStripMenuItem = new ToolStripMenuItem();
            размытиеToolStripMenuItem = new ToolStripMenuItem();
            размытиеВДвиженииToolStripMenuItem = new ToolStripMenuItem();
            тиснениеToolStripMenuItem = new ToolStripMenuItem();
            светящиесяКраяToolStripMenuItem = new ToolStripMenuItem();
            глобальныеToolStripMenuItem = new ToolStripMenuItem();
            линейноеРастяжениеГистограммыToolStripMenuItem = new ToolStripMenuItem();
            серыйМирToolStripMenuItem = new ToolStripMenuItem();
            идеальныйОтражательToolStripMenuItem = new ToolStripMenuItem();
            коррекцияСОпорнымЦветомToolStripMenuItem = new ToolStripMenuItem();
            морфологияToolStripMenuItem = new ToolStripMenuItem();
            расширениеToolStripMenuItem = new ToolStripMenuItem();
            сужениеToolStripMenuItem = new ToolStripMenuItem();
            открытиеToolStripMenuItem = new ToolStripMenuItem();
            закрытиеToolStripMenuItem = new ToolStripMenuItem();
            gradToolStripMenuItem = new ToolStripMenuItem();
            topHatToolStripMenuItem = new ToolStripMenuItem();
            blackHatToolStripMenuItem = new ToolStripMenuItem();
            настройкиToolStripMenuItem = new ToolStripMenuItem();
            настроитьСтруктурныйЭлементToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1 = new Panel();
            button2 = new Button();
            настроитьОпорныйЦветToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, фильтрыToolStripMenuItem, настройкиToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem, выйтиToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(166, 26);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(166, 26);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // выйтиToolStripMenuItem
            // 
            выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            выйтиToolStripMenuItem.Size = new Size(166, 26);
            выйтиToolStripMenuItem.Text = "Выйти";
            выйтиToolStripMenuItem.Click += выйтиToolStripMenuItem_Click;
            // 
            // фильтрыToolStripMenuItem
            // 
            фильтрыToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { точечныеToolStripMenuItem, матричныеToolStripMenuItem, глобальныеToolStripMenuItem, морфологияToolStripMenuItem });
            фильтрыToolStripMenuItem.Name = "фильтрыToolStripMenuItem";
            фильтрыToolStripMenuItem.Size = new Size(85, 24);
            фильтрыToolStripMenuItem.Text = "Фильтры";
            // 
            // точечныеToolStripMenuItem
            // 
            точечныеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { волныToolStripMenuItem, инверсияToolStripMenuItem, переносToolStripMenuItem, поворотToolStripMenuItem, повысить_яркостьtoolStripMenuItem, сделатьЧернобелымToolStripMenuItem, сепияToolStripMenuItem, эффектстеклаToolStripMenuItem });
            точечныеToolStripMenuItem.Name = "точечныеToolStripMenuItem";
            точечныеToolStripMenuItem.Size = new Size(224, 26);
            точечныеToolStripMenuItem.Text = "Точечные";
            // 
            // волныToolStripMenuItem
            // 
            волныToolStripMenuItem.Name = "волныToolStripMenuItem";
            волныToolStripMenuItem.Size = new Size(247, 26);
            волныToolStripMenuItem.Text = "Волны";
            волныToolStripMenuItem.Click += волныToolStripMenuItem_Click;
            // 
            // инверсияToolStripMenuItem
            // 
            инверсияToolStripMenuItem.Name = "инверсияToolStripMenuItem";
            инверсияToolStripMenuItem.Size = new Size(247, 26);
            инверсияToolStripMenuItem.Text = "Инверсия";
            инверсияToolStripMenuItem.Click += инверсияToolStripMenuItem_Click;
            // 
            // переносToolStripMenuItem
            // 
            переносToolStripMenuItem.Name = "переносToolStripMenuItem";
            переносToolStripMenuItem.Size = new Size(247, 26);
            переносToolStripMenuItem.Text = "Перенос";
            переносToolStripMenuItem.Click += переносToolStripMenuItem_Click;
            // 
            // поворотToolStripMenuItem
            // 
            поворотToolStripMenuItem.Name = "поворотToolStripMenuItem";
            поворотToolStripMenuItem.Size = new Size(247, 26);
            поворотToolStripMenuItem.Text = "Поворот";
            поворотToolStripMenuItem.Click += поворотToolStripMenuItem_Click;
            // 
            // повысить_яркостьtoolStripMenuItem
            // 
            повысить_яркостьtoolStripMenuItem.Name = "повысить_яркостьtoolStripMenuItem";
            повысить_яркостьtoolStripMenuItem.Size = new Size(247, 26);
            повысить_яркостьtoolStripMenuItem.Text = "Повысить яркость";
            повысить_яркостьtoolStripMenuItem.Click += повысить_яркостьtoolStripMenuItem_Click;
            // 
            // сделатьЧернобелымToolStripMenuItem
            // 
            сделатьЧернобелымToolStripMenuItem.Name = "сделатьЧернобелымToolStripMenuItem";
            сделатьЧернобелымToolStripMenuItem.Size = new Size(247, 26);
            сделатьЧернобелымToolStripMenuItem.Text = "Сделать черно-белым";
            сделатьЧернобелымToolStripMenuItem.Click += сделатьЧернобелымToolStripMenuItem_Click;
            // 
            // сепияToolStripMenuItem
            // 
            сепияToolStripMenuItem.Name = "сепияToolStripMenuItem";
            сепияToolStripMenuItem.Size = new Size(247, 26);
            сепияToolStripMenuItem.Text = "Сепия";
            сепияToolStripMenuItem.Click += сепияToolStripMenuItem_Click;
            // 
            // эффектстеклаToolStripMenuItem
            // 
            эффектстеклаToolStripMenuItem.Name = "эффектстеклаToolStripMenuItem";
            эффектстеклаToolStripMenuItem.Size = new Size(247, 26);
            эффектстеклаToolStripMenuItem.Text = "Эффект «стекла»";
            эффектстеклаToolStripMenuItem.Click += эффектстеклаToolStripMenuItem_Click;
            // 
            // матричныеToolStripMenuItem
            // 
            матричныеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { выделениеГраницToolStripMenuItem, изменениеРезкостиToolStripMenuItem, медианныйФильтрToolStripMenuItem, операторСобеляToolStripMenuItem, поГауссуToolStripMenuItem, размытиеToolStripMenuItem, размытиеВДвиженииToolStripMenuItem, тиснениеToolStripMenuItem, светящиесяКраяToolStripMenuItem });
            матричныеToolStripMenuItem.Name = "матричныеToolStripMenuItem";
            матричныеToolStripMenuItem.Size = new Size(224, 26);
            матричныеToolStripMenuItem.Text = "Матричные";
            // 
            // выделениеГраницToolStripMenuItem
            // 
            выделениеГраницToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { операторПрюиттаToolStripMenuItem, операторЩарраToolStripMenuItem });
            выделениеГраницToolStripMenuItem.Name = "выделениеГраницToolStripMenuItem";
            выделениеГраницToolStripMenuItem.Size = new Size(247, 26);
            выделениеГраницToolStripMenuItem.Text = "Выделение границ";
            // 
            // операторПрюиттаToolStripMenuItem
            // 
            операторПрюиттаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { поXToolStripMenuItem2, поYToolStripMenuItem2 });
            операторПрюиттаToolStripMenuItem.Name = "операторПрюиттаToolStripMenuItem";
            операторПрюиттаToolStripMenuItem.Size = new Size(226, 26);
            операторПрюиттаToolStripMenuItem.Text = "Оператор Прюитта";
            // 
            // поXToolStripMenuItem2
            // 
            поXToolStripMenuItem2.Name = "поXToolStripMenuItem2";
            поXToolStripMenuItem2.Size = new Size(125, 26);
            поXToolStripMenuItem2.Text = "По X";
            поXToolStripMenuItem2.Click += поXToolStripMenuItem2_Click;
            // 
            // поYToolStripMenuItem2
            // 
            поYToolStripMenuItem2.Name = "поYToolStripMenuItem2";
            поYToolStripMenuItem2.Size = new Size(125, 26);
            поYToolStripMenuItem2.Text = "По Y";
            поYToolStripMenuItem2.Click += поYToolStripMenuItem2_Click;
            // 
            // операторЩарраToolStripMenuItem
            // 
            операторЩарраToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { поXToolStripMenuItem1, поYToolStripMenuItem1 });
            операторЩарраToolStripMenuItem.Name = "операторЩарраToolStripMenuItem";
            операторЩарраToolStripMenuItem.Size = new Size(226, 26);
            операторЩарраToolStripMenuItem.Text = "Оператор Щарра";
            // 
            // поXToolStripMenuItem1
            // 
            поXToolStripMenuItem1.Name = "поXToolStripMenuItem1";
            поXToolStripMenuItem1.Size = new Size(125, 26);
            поXToolStripMenuItem1.Text = "По X";
            поXToolStripMenuItem1.Click += поXToolStripMenuItem1_Click;
            // 
            // поYToolStripMenuItem1
            // 
            поYToolStripMenuItem1.Name = "поYToolStripMenuItem1";
            поYToolStripMenuItem1.Size = new Size(125, 26);
            поYToolStripMenuItem1.Text = "По Y";
            поYToolStripMenuItem1.Click += поYToolStripMenuItem1_Click;
            // 
            // изменениеРезкостиToolStripMenuItem
            // 
            изменениеРезкостиToolStripMenuItem.Name = "изменениеРезкостиToolStripMenuItem";
            изменениеРезкостиToolStripMenuItem.Size = new Size(247, 26);
            изменениеРезкостиToolStripMenuItem.Text = "Изменение резкости";
            изменениеРезкостиToolStripMenuItem.Click += изменениеРезкостиToolStripMenuItem_Click;
            // 
            // медианныйФильтрToolStripMenuItem
            // 
            медианныйФильтрToolStripMenuItem.Name = "медианныйФильтрToolStripMenuItem";
            медианныйФильтрToolStripMenuItem.Size = new Size(247, 26);
            медианныйФильтрToolStripMenuItem.Text = "Медианный фильтр";
            медианныйФильтрToolStripMenuItem.Click += медианныйФильтрToolStripMenuItem_Click;
            // 
            // операторСобеляToolStripMenuItem
            // 
            операторСобеляToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { поXToolStripMenuItem, поYToolStripMenuItem });
            операторСобеляToolStripMenuItem.Name = "операторСобеляToolStripMenuItem";
            операторСобеляToolStripMenuItem.Size = new Size(247, 26);
            операторСобеляToolStripMenuItem.Text = "Оператор Собеля";
            // 
            // поXToolStripMenuItem
            // 
            поXToolStripMenuItem.Name = "поXToolStripMenuItem";
            поXToolStripMenuItem.Size = new Size(125, 26);
            поXToolStripMenuItem.Text = "По X";
            поXToolStripMenuItem.Click += поXToolStripMenuItem_Click;
            // 
            // поYToolStripMenuItem
            // 
            поYToolStripMenuItem.Name = "поYToolStripMenuItem";
            поYToolStripMenuItem.Size = new Size(125, 26);
            поYToolStripMenuItem.Text = "По Y";
            поYToolStripMenuItem.Click += поYToolStripMenuItem_Click;
            // 
            // поГауссуToolStripMenuItem
            // 
            поГауссуToolStripMenuItem.Name = "поГауссуToolStripMenuItem";
            поГауссуToolStripMenuItem.Size = new Size(247, 26);
            поГауссуToolStripMenuItem.Text = "По Гауссу";
            поГауссуToolStripMenuItem.Click += поГауссуToolStripMenuItem_Click;
            // 
            // размытиеToolStripMenuItem
            // 
            размытиеToolStripMenuItem.Name = "размытиеToolStripMenuItem";
            размытиеToolStripMenuItem.Size = new Size(247, 26);
            размытиеToolStripMenuItem.Text = "Размытие";
            размытиеToolStripMenuItem.Click += размытиеToolStripMenuItem_Click;
            // 
            // размытиеВДвиженииToolStripMenuItem
            // 
            размытиеВДвиженииToolStripMenuItem.Name = "размытиеВДвиженииToolStripMenuItem";
            размытиеВДвиженииToolStripMenuItem.Size = new Size(247, 26);
            размытиеВДвиженииToolStripMenuItem.Text = "Размытие в движении";
            размытиеВДвиженииToolStripMenuItem.Click += размытиеВДвиженииToolStripMenuItem_Click;
            // 
            // тиснениеToolStripMenuItem
            // 
            тиснениеToolStripMenuItem.Name = "тиснениеToolStripMenuItem";
            тиснениеToolStripMenuItem.Size = new Size(247, 26);
            тиснениеToolStripMenuItem.Text = "Тиснение";
            тиснениеToolStripMenuItem.Click += тиснениеToolStripMenuItem_Click;
            // 
            // светящиесяКраяToolStripMenuItem
            // 
            светящиесяКраяToolStripMenuItem.Name = "светящиесяКраяToolStripMenuItem";
            светящиесяКраяToolStripMenuItem.Size = new Size(247, 26);
            светящиесяКраяToolStripMenuItem.Text = "Светящиеся края";
            светящиесяКраяToolStripMenuItem.Click += светящиесяКраяToolStripMenuItem_Click;
            // 
            // глобальныеToolStripMenuItem
            // 
            глобальныеToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { линейноеРастяжениеГистограммыToolStripMenuItem, серыйМирToolStripMenuItem, идеальныйОтражательToolStripMenuItem, коррекцияСОпорнымЦветомToolStripMenuItem });
            глобальныеToolStripMenuItem.Name = "глобальныеToolStripMenuItem";
            глобальныеToolStripMenuItem.Size = new Size(224, 26);
            глобальныеToolStripMenuItem.Text = "Глобальные";
            // 
            // линейноеРастяжениеГистограммыToolStripMenuItem
            // 
            линейноеРастяжениеГистограммыToolStripMenuItem.Name = "линейноеРастяжениеГистограммыToolStripMenuItem";
            линейноеРастяжениеГистограммыToolStripMenuItem.Size = new Size(347, 26);
            линейноеРастяжениеГистограммыToolStripMenuItem.Text = "Линейное растяжение гистограммы";
            линейноеРастяжениеГистограммыToolStripMenuItem.Click += линейноеРастяжениеГистограммыToolStripMenuItem_Click;
            // 
            // серыйМирToolStripMenuItem
            // 
            серыйМирToolStripMenuItem.Name = "серыйМирToolStripMenuItem";
            серыйМирToolStripMenuItem.Size = new Size(347, 26);
            серыйМирToolStripMenuItem.Text = "Серый мир";
            серыйМирToolStripMenuItem.Click += серыйМирToolStripMenuItem_Click;
            // 
            // идеальныйОтражательToolStripMenuItem
            // 
            идеальныйОтражательToolStripMenuItem.Name = "идеальныйОтражательToolStripMenuItem";
            идеальныйОтражательToolStripMenuItem.Size = new Size(347, 26);
            идеальныйОтражательToolStripMenuItem.Text = "Идеальный отражатель";
            идеальныйОтражательToolStripMenuItem.Click += идеальныйОтражательToolStripMenuItem_Click;
            // 
            // коррекцияСОпорнымЦветомToolStripMenuItem
            // 
            коррекцияСОпорнымЦветомToolStripMenuItem.Name = "коррекцияСОпорнымЦветомToolStripMenuItem";
            коррекцияСОпорнымЦветомToolStripMenuItem.Size = new Size(347, 26);
            коррекцияСОпорнымЦветомToolStripMenuItem.Text = "Коррекция с опорным цветом";
            коррекцияСОпорнымЦветомToolStripMenuItem.Click += коррекцияСОпорнымЦветомToolStripMenuItem_Click;
            // 
            // морфологияToolStripMenuItem
            // 
            морфологияToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { расширениеToolStripMenuItem, сужениеToolStripMenuItem, открытиеToolStripMenuItem, закрытиеToolStripMenuItem, gradToolStripMenuItem, topHatToolStripMenuItem, blackHatToolStripMenuItem });
            морфологияToolStripMenuItem.Name = "морфологияToolStripMenuItem";
            морфологияToolStripMenuItem.Size = new Size(224, 26);
            морфологияToolStripMenuItem.Text = "Морфология";
            // 
            // расширениеToolStripMenuItem
            // 
            расширениеToolStripMenuItem.Name = "расширениеToolStripMenuItem";
            расширениеToolStripMenuItem.Size = new Size(179, 26);
            расширениеToolStripMenuItem.Text = "Расширение";
            расширениеToolStripMenuItem.Click += расширениеToolStripMenuItem_Click;
            // 
            // сужениеToolStripMenuItem
            // 
            сужениеToolStripMenuItem.Name = "сужениеToolStripMenuItem";
            сужениеToolStripMenuItem.Size = new Size(179, 26);
            сужениеToolStripMenuItem.Text = "Сужение";
            сужениеToolStripMenuItem.Click += сужениеToolStripMenuItem_Click;
            // 
            // открытиеToolStripMenuItem
            // 
            открытиеToolStripMenuItem.Name = "открытиеToolStripMenuItem";
            открытиеToolStripMenuItem.Size = new Size(179, 26);
            открытиеToolStripMenuItem.Text = "Открытие";
            открытиеToolStripMenuItem.Click += открытиеToolStripMenuItem_Click;
            // 
            // закрытиеToolStripMenuItem
            // 
            закрытиеToolStripMenuItem.Name = "закрытиеToolStripMenuItem";
            закрытиеToolStripMenuItem.Size = new Size(179, 26);
            закрытиеToolStripMenuItem.Text = "Закрытие";
            закрытиеToolStripMenuItem.Click += закрытиеToolStripMenuItem_Click;
            // 
            // gradToolStripMenuItem
            // 
            gradToolStripMenuItem.Name = "gradToolStripMenuItem";
            gradToolStripMenuItem.Size = new Size(179, 26);
            gradToolStripMenuItem.Text = "Градиент";
            gradToolStripMenuItem.Click += gradToolStripMenuItem_Click;
            // 
            // topHatToolStripMenuItem
            // 
            topHatToolStripMenuItem.Name = "topHatToolStripMenuItem";
            topHatToolStripMenuItem.Size = new Size(179, 26);
            topHatToolStripMenuItem.Text = "Top Hat";
            topHatToolStripMenuItem.Click += topHatToolStripMenuItem_Click;
            // 
            // blackHatToolStripMenuItem
            // 
            blackHatToolStripMenuItem.Name = "blackHatToolStripMenuItem";
            blackHatToolStripMenuItem.Size = new Size(179, 26);
            blackHatToolStripMenuItem.Text = "Black Hat";
            blackHatToolStripMenuItem.Click += blackHatToolStripMenuItem_Click;
            // 
            // настройкиToolStripMenuItem
            // 
            настройкиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { настроитьСтруктурныйЭлементToolStripMenuItem, настроитьОпорныйЦветToolStripMenuItem });
            настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            настройкиToolStripMenuItem.Size = new Size(98, 24);
            настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // настроитьСтруктурныйЭлементToolStripMenuItem
            // 
            настроитьСтруктурныйЭлементToolStripMenuItem.Name = "настроитьСтруктурныйЭлементToolStripMenuItem";
            настроитьСтруктурныйЭлементToolStripMenuItem.Size = new Size(317, 26);
            настроитьСтруктурныйЭлементToolStripMenuItem.Text = "Настроить структурный элемент";
            настроитьСтруктурныйЭлементToolStripMenuItem.Click += настроитьСтруктурныйЭлементToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Location = new Point(0, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 393);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Bottom;
            progressBar1.Location = new Point(0, 421);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(800, 29);
            progressBar1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(2, 31);
            button1.Name = "button1";
            button1.Size = new Size(117, 29);
            button1.TabIndex = 3;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // backgroundWorker1
            // 
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(666, 352);
            panel1.Name = "panel1";
            panel1.Size = new Size(122, 63);
            panel1.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(116, 29);
            button2.TabIndex = 5;
            button2.Text = "Назад";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // настроитьОпорныйЦветToolStripMenuItem
            // 
            настроитьОпорныйЦветToolStripMenuItem.Name = "настроитьОпорныйЦветToolStripMenuItem";
            настроитьОпорныйЦветToolStripMenuItem.Size = new Size(317, 26);
            настроитьОпорныйЦветToolStripMenuItem.Text = "Настроить опорный цвет";
            настроитьОпорныйЦветToolStripMenuItem.Click += настроитьОпорныйЦветToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Aboba Photozhab";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem фильтрыToolStripMenuItem;
        private ToolStripMenuItem точечныеToolStripMenuItem;
        private ToolStripMenuItem инверсияToolStripMenuItem;
        private ToolStripMenuItem матричныеToolStripMenuItem;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem файлToolStripMenuItem1;
        private ToolStripMenuItem открытьToolStripMenuItem1;
        private ToolStripMenuItem фильтрыToolStripMenuItem1;
        private ToolStripMenuItem точечныеToolStripMenuItem1;
        private ToolStripMenuItem инверсияToolStripMenuItem1;
        private ToolStripMenuItem матричныеToolStripMenuItem1;
        private ProgressBar progressBar1;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ToolStripMenuItem размытиеToolStripMenuItem;
        private ToolStripMenuItem поГауссуToolStripMenuItem;
        private ToolStripMenuItem выйтиToolStripMenuItem;
        private Panel panel1;
        private ToolStripMenuItem сделатьЧернобелымToolStripMenuItem;
        private ToolStripMenuItem сепияToolStripMenuItem;
        private ToolStripMenuItem повысить_яркостьtoolStripMenuItem;
        private ToolStripMenuItem операторСобеляToolStripMenuItem;
        private ToolStripMenuItem поXToolStripMenuItem;
        private ToolStripMenuItem поYToolStripMenuItem;
        private ToolStripMenuItem изменениеРезкостиToolStripMenuItem;
        private ToolStripMenuItem выделениеГраницToolStripMenuItem;
        private ToolStripMenuItem операторЩарраToolStripMenuItem;
        private ToolStripMenuItem поXToolStripMenuItem1;
        private ToolStripMenuItem поYToolStripMenuItem1;
        private ToolStripMenuItem операторПрюиттаToolStripMenuItem;
        private ToolStripMenuItem поXToolStripMenuItem2;
        private ToolStripMenuItem поYToolStripMenuItem2;
        private ToolStripMenuItem тиснениеToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private Button button2;
        private ToolStripMenuItem волныToolStripMenuItem;
        private ToolStripMenuItem переносToolStripMenuItem;
        private ToolStripMenuItem поворотToolStripMenuItem;
        private ToolStripMenuItem эффектстеклаToolStripMenuItem;
        private ToolStripMenuItem размытиеВДвиженииToolStripMenuItem;
        private ToolStripMenuItem глобальныеToolStripMenuItem;
        private ToolStripMenuItem серыйМирToolStripMenuItem;
        private ToolStripMenuItem линейноеРастяжениеГистограммыToolStripMenuItem;
        private ToolStripMenuItem медианныйФильтрToolStripMenuItem;
        private ToolStripMenuItem морфологияToolStripMenuItem;
        private ToolStripMenuItem расширениеToolStripMenuItem;
        private ToolStripMenuItem сужениеToolStripMenuItem;
        private ToolStripMenuItem открытиеToolStripMenuItem;
        private ToolStripMenuItem закрытиеToolStripMenuItem;
        private ToolStripMenuItem gradToolStripMenuItem;
        private ToolStripMenuItem светящиесяКраяToolStripMenuItem;
        private ToolStripMenuItem идеальныйОтражательToolStripMenuItem;
        private ToolStripMenuItem topHatToolStripMenuItem;
        private ToolStripMenuItem blackHatToolStripMenuItem;
        private ToolStripMenuItem настройкиToolStripMenuItem;
        private ToolStripMenuItem настроитьСтруктурныйЭлементToolStripMenuItem;
        private ToolStripMenuItem коррекцияСОпорнымЦветомToolStripMenuItem;
        private ToolStripMenuItem настроитьОпорныйЦветToolStripMenuItem;
    }
}