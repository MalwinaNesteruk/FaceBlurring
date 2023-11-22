using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceBlurring
{
    public partial class MultiImagesControl : UserControl
    {
        int index = 0;

        public MultiImagesControl()
        {
            InitializeComponent();
        }


        internal void LoadPictures()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {              
                string folderPath = folderBrowserDialog1.SelectedPath;
                var files = Directory.GetFiles(folderPath).Where(file => Regex.IsMatch(file, @"^.+\.(JPG|jpg|png|PNG)$")).ToList();
                int addToDown = 106;
                int currentPicBoxLocation = 3;
                button1.Visible = true;
                button2.Visible = true;
                foreach (var file in files)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.BackgroundImage = Image.FromFile(file);
                    pictureBox.BackgroundImageLayout = ImageLayout.Zoom;
                    pictureBox.Size = new Size(140, 100);
                    panel1.Controls.Add(pictureBox);
                    pictureBox.Location = new Point(3, currentPicBoxLocation);
                    currentPicBoxLocation = currentPicBoxLocation + addToDown;

                    pictureBox.MouseClick += new MouseEventHandler((sender, evt) => { 
                        pictureBox1.BackgroundImage = pictureBox.BackgroundImage; 
                        pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
                        index = panel1.Controls.IndexOf(pictureBox);
                    });
                }

                pictureBox1.BackgroundImage = panel1.Controls[0].BackgroundImage;
                pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            }

            else
            {
                openFileDialog1.Dispose(); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index--;
            if (index < 0)
            {
                index = panel1.Controls.Count - 1;
                pictureBox1.BackgroundImage = panel1.Controls[index].BackgroundImage;
            }

            else
            {
                pictureBox1.BackgroundImage = panel1.Controls[index].BackgroundImage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            index++;
            if (index == panel1.Controls.Count)
            {
                index = 0;
                pictureBox1.BackgroundImage = panel1.Controls[index].BackgroundImage;
            }

            else
            {
                pictureBox1.BackgroundImage = panel1.Controls[index].BackgroundImage;
            }
        }
    }
}
