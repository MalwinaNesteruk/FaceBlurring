using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier(@"C:\Users\Malwina\source\repos\FaceBlurring\WindowsFormsApp1\haarcascade_frontalface_default.xml");
        public Form1()
        {
            InitializeComponent();
        }

        private void załadujObrazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //tutaj jeszcze czyścić picturebox
                string filePath = openFileDialog1.FileName;
                pictureBox1.BackgroundImage = Image.FromFile(filePath);
                pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            }

            else
            {
                openFileDialog1.Dispose();
            }

        }

        private void wymażTwarzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.BackgroundImage != null)
            {
                
                Bitmap bitmap = new Bitmap(pictureBox1.BackgroundImage);
                Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);
                Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.30, 9);
                foreach (Rectangle rect in rectangles)
                {
                    using (Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        using (SolidBrush brush = new SolidBrush(Color.Maroon))
                        {
                            graphics.FillRectangles(brush, rectangles);
                        }
                    }
                }
                pictureBox1.BackgroundImage = bitmap;
            }
        }

        private void zapiszObrazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = string.Empty;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackgroundImage.Save(saveFileDialog1.FileName);
            }

            else
            {
                saveFileDialog1.Dispose();
            }

        }

        private void załadujObrazyZFolderuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            multiImagesControl1.LoadPictures();
        }
    }
}
