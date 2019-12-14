using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap bmp = new Bitmap("C:\\Users\\Anton\\ImgPrc\\Image-processing\\Ex1\\Izmaylovo.bmp");
        byte i1, i2, i3;
        Image MemForImage;

        
        private void LoadImage(bool Bmp)
        {
            openFileDialog1.InitialDirectory = "C:\\Users\\Anton\\ImgPrc\\Image-processing\\Ex1";
            if (Bmp)
                openFileDialog1.Filter = "image (BMP) files (*.bmp)|*.bmp|All files (*.*)|*.*";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    MemForImage = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image = MemForImage;
                    bmp = (Bitmap)pictureBox1.Image;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot load a file: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)pictureBox1.Image;
            double N1, N2, N3;
            N1 = trackBar1.Value;
            N2 = trackBar2.Value;
            N3 = trackBar3.Value;
            bool ok = true;
            if (N1 == 0 && N2 == 0 && N3 == 0)
                ok = false;
            for (int x = 0; x < bmp.Width; x++)
            {
                for (int y = 0; y < bmp.Height; y++)
                {
                    Color col = bmp.GetPixel(x, y);
                    byte r, g, b;
                    r = col.R;
                    g = col.G;
                    b = col.B;
                    // Standart formula for conversion:
                    // byte gray = (byte)(0.3 * r + 0.59 * g + 0.11 * b);
                    byte gray;
                    // Formula using input coefficients:
                    if (ok)
                        gray = (byte)((N1 / (N1 + N2 + N3)) * r + (N2 / (N1 + N2 + N3)) * g + (N3 / (N1 + N2 + N3)) * b);
                    else
                        gray = (byte)(N1 * r + N2 * g + N3 * b);
                    bmp.SetPixel(x, y, Color.FromArgb(gray, gray, gray));
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = bmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i1 = (byte)trackBar1.Value;
            textBox1.Text = Convert.ToString(i1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i2 = (byte)trackBar2.Value;
            textBox2.Text = Convert.ToString(i2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            i3 = (byte)trackBar3.Value;
            textBox3.Text = Convert.ToString(i3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoadImage(true);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Bitmap I = (Bitmap)pictureBox2.Image;
            byte gray;
            int[] X = new int[256];
            for (int i = 0; i < 256; i++)
                X[i] = i;
            int[] H = new int[256];
            for (int i = 0; i < 256; i++)
                H[i] = 0;
            for (int x = 0; x < I.Width; x++ )
            {
                for (int y = 0; y < I.Height; y++)
                {
                    gray = I.GetPixel(x, y).R;
                    H[gray]++;
                }
            }
            

            this.chart1.Series["Grayscale"].Points.DataBindXY(X, H);
            for (int i = 0; i < 256; i++)
            {
                this.chart1.Series["Grayscale"].Points[i].Color = Color.FromArgb(i, i, i);
            }

        }
    }
}
