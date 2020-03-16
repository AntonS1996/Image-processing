namespace Ex1
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GrayScaleProcessButton = new System.Windows.Forms.Button();
            this.ShowResultImageButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.RTrackBar = new System.Windows.Forms.TrackBar();
            this.GTrackBar = new System.Windows.Forms.TrackBar();
            this.BTrackBar = new System.Windows.Forms.TrackBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RButton = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.GButton = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BButton = new System.Windows.Forms.Button();
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(371, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GrayScaleProcessButton
            // 
            this.GrayScaleProcessButton.Enabled = false;
            this.GrayScaleProcessButton.Location = new System.Drawing.Point(771, 35);
            this.GrayScaleProcessButton.Name = "GrayScaleProcessButton";
            this.GrayScaleProcessButton.Size = new System.Drawing.Size(75, 23);
            this.GrayScaleProcessButton.TabIndex = 1;
            this.GrayScaleProcessButton.Text = "Process";
            this.GrayScaleProcessButton.UseVisualStyleBackColor = true;
            this.GrayScaleProcessButton.Click += new System.EventHandler(this.GrayScaleProcessButton_Click);
            // 
            // ShowResultImageButton
            // 
            this.ShowResultImageButton.Enabled = false;
            this.ShowResultImageButton.Location = new System.Drawing.Point(771, 81);
            this.ShowResultImageButton.Name = "ShowResultImageButton";
            this.ShowResultImageButton.Size = new System.Drawing.Size(75, 23);
            this.ShowResultImageButton.TabIndex = 2;
            this.ShowResultImageButton.Text = "Result";
            this.ShowResultImageButton.UseVisualStyleBackColor = true;
            this.ShowResultImageButton.Click += new System.EventHandler(this.ShowResultImageButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 292);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(371, 262);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // RTrackBar
            // 
            this.RTrackBar.Location = new System.Drawing.Point(501, 35);
            this.RTrackBar.Maximum = 255;
            this.RTrackBar.Name = "RTrackBar";
            this.RTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RTrackBar.Size = new System.Drawing.Size(45, 214);
            this.RTrackBar.TabIndex = 4;
            // 
            // GTrackBar
            // 
            this.GTrackBar.Location = new System.Drawing.Point(594, 35);
            this.GTrackBar.Maximum = 255;
            this.GTrackBar.Name = "GTrackBar";
            this.GTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.GTrackBar.Size = new System.Drawing.Size(45, 214);
            this.GTrackBar.TabIndex = 5;
            // 
            // BTrackBar
            // 
            this.BTrackBar.Location = new System.Drawing.Point(687, 35);
            this.BTrackBar.Maximum = 255;
            this.BTrackBar.Name = "BTrackBar";
            this.BTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.BTrackBar.Size = new System.Drawing.Size(45, 214);
            this.BTrackBar.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(479, 255);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(67, 20);
            this.textBox1.TabIndex = 7;
            // 
            // RButton
            // 
            this.RButton.Location = new System.Drawing.Point(479, 12);
            this.RButton.Name = "RButton";
            this.RButton.Size = new System.Drawing.Size(67, 23);
            this.RButton.TabIndex = 8;
            this.RButton.Text = "Show";
            this.RButton.UseVisualStyleBackColor = true;
            this.RButton.Click += new System.EventHandler(this.RButton_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(572, 255);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(67, 20);
            this.textBox2.TabIndex = 9;
            // 
            // GButton
            // 
            this.GButton.Location = new System.Drawing.Point(572, 12);
            this.GButton.Name = "GButton";
            this.GButton.Size = new System.Drawing.Size(67, 23);
            this.GButton.TabIndex = 10;
            this.GButton.Text = "Show";
            this.GButton.UseVisualStyleBackColor = true;
            this.GButton.Click += new System.EventHandler(this.GButton_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(665, 255);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(67, 20);
            this.textBox3.TabIndex = 11;
            // 
            // BButton
            // 
            this.BButton.Location = new System.Drawing.Point(665, 12);
            this.BButton.Name = "BButton";
            this.BButton.Size = new System.Drawing.Size(67, 23);
            this.BButton.TabIndex = 12;
            this.BButton.Text = "Show";
            this.BButton.UseVisualStyleBackColor = true;
            this.BButton.Click += new System.EventHandler(this.BButton_Click);
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.Location = new System.Drawing.Point(771, 161);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(75, 23);
            this.LoadImageButton.TabIndex = 13;
            this.LoadImageButton.Text = "Load";
            this.LoadImageButton.UseVisualStyleBackColor = true;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(450, 292);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Legend = "Legend1";
            series1.Name = "Grayscale";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(493, 262);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // ChartButton
            // 
            this.ChartButton.Enabled = false;
            this.ChartButton.Location = new System.Drawing.Point(832, 251);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(75, 23);
            this.ChartButton.TabIndex = 15;
            this.ChartButton.Text = "Chart";
            this.ChartButton.UseVisualStyleBackColor = true;
            this.ChartButton.Click += new System.EventHandler(this.ChartButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 697);
            this.Controls.Add(this.ChartButton);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.LoadImageButton);
            this.Controls.Add(this.BButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.GButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.RButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BTrackBar);
            this.Controls.Add(this.GTrackBar);
            this.Controls.Add(this.RTrackBar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ShowResultImageButton);
            this.Controls.Add(this.GrayScaleProcessButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image processing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button GrayScaleProcessButton;
        private System.Windows.Forms.Button ShowResultImageButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TrackBar RTrackBar;
        private System.Windows.Forms.TrackBar GTrackBar;
        private System.Windows.Forms.TrackBar BTrackBar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button RButton;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button GButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button BButton;
        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button ChartButton;
    }
}

