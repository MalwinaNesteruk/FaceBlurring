using Emgu.CV;
using Emgu.CV.Structure;
using System.Drawing.Text;

namespace FaceBlurring
{
    public partial class Form1 : Form
    {
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
        public Form1()
        {
            InitializeComponent();
        }

        private void za³adujObrazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //tutaj jeszcze czyœciæ picturebox
                string filePath = openFileDialog1.FileName;
                pictureBox1.BackgroundImage = Image.FromFile(filePath);
                pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            }

            else
            {
                openFileDialog1.Dispose();
            }

        }

        private void wyma¿TwarzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (pictureBox1.BackgroundImage != null)
            //{
            //    Bitmap bitmap = new Bitmap(pictureBox1.BackgroundImage);
            //    Image<Bgr, byte> grayImage = new Image<Bgr, byte>(bitmap);
            //    Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.4, 0);
            //    foreach (Rectangle rect in rectangles)
            //    {
            //        using (Graphics graphics = Graphics.FromImage(bitmap))
            //        {
            //            using (Pen pen = new Pen(Color.Red, 1))
            //            {
            //                graphics.DrawRectangle(pen, rect);
            //            }
            //        }
            //    }
            //    pictureBox1.BackgroundImage = bitmap;
            //}
        }
    }
} 