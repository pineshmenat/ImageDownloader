using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageDownloader
{
    public partial class Form1 : Form
    {
        ImageDownloadServiceReference.ImageDownloadServiceClient client;
        public Form1()
        {
            InitializeComponent();
            client = new ImageDownloadServiceReference.ImageDownloadServiceClient("BasicHttpBinding_IImageDownloadService");
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //BhYBtFuDudT BhQ9rNSjy-8 BhNwLkCDGLw BhI7-KgjTNt Bhjh1oUjVmC
                bool status = client.saveTodaysBingWallpaper();
                status = client.downloadInstagramImage("https://www.instagram.com/p/Bhjh1oUjVmC/");

                List<ImageDownloadServiceReference.Image> bingWallpapers = client.getInstagramImages().ToList<ImageDownloadServiceReference.Image>();

                System.IO.Stream stream = new MemoryStream(bingWallpapers[0].image);
                Bitmap bmp = new Bitmap(stream);
                bmp.Save(bingWallpapers[0].image_name);
                //pictureBox1.Size = new Size(200, 200);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = new Bitmap(stream);

                setGalleryWithImages();

            }
            catch (FaultException<ImageDownloadServiceReference.InvalidUrlFault> obj)
            {
                String error= obj.Detail.Error + " " + obj.Detail.Details;
            }
        }

        private void setGalleryWithImages()//on bing tab from disk
        {
            tabPageBing.Controls.Clear();
            tabPageInstagram.Controls.Clear();

            List<ImageDownloadServiceReference.Image> bingWallpapers = client.getBingWallpapers().ToList<ImageDownloadServiceReference.Image>();
            List<ImageDownloadServiceReference.Image> instagramWallpapers = client.getInstagramImages().ToList<ImageDownloadServiceReference.Image>();
            List<System.IO.Stream> streamList = new List<Stream>();

            //Bing
            foreach (ImageDownloadServiceReference.Image img in bingWallpapers)
                streamList.Add(new MemoryStream(img.image));
            PictureBox[] picturebox = new PictureBox[bingWallpapers.Count];
            int y = -250, temp = 0;
            for (int index = 0; index < picturebox.Length; index++)
            {
                picturebox[index] = new PictureBox();
                picturebox[index].Click += PictureBoxClick;
                tabPageBing.Controls.Add(picturebox[index]);
                if (index % 2 == 0)
                {
                    y = y + 250; // 3 images per rows
                    temp = 0;
                }
                else
                {
                    temp++;
                }
                picturebox[index].Location = new Point(temp * 250 + 20, y);
                picturebox[index].Size = new Size(250, 250);
                picturebox[index].SizeMode = PictureBoxSizeMode.StretchImage;
                picturebox[index].Image = new Bitmap(streamList[index]);//Image.FromFile(list[index])
            }

            //Instagram
            streamList.Clear();
            foreach (ImageDownloadServiceReference.Image img in instagramWallpapers)
                streamList.Add(new MemoryStream(img.image));
            picturebox = new PictureBox[instagramWallpapers.Count];
            y = -250; temp = 0;
            for (int index = 0; index < picturebox.Length; index++)
            {
                picturebox[index] = new PictureBox();
                picturebox[index].Click += PictureBoxClick;
                tabPageInstagram.Controls.Add(picturebox[index]);
                if (index % 2 == 0)
                {
                    y = y + 250; // 3 images per rows
                    temp = 0;
                }
                else
                {
                    temp++;
                }
                picturebox[index].Location = new Point(temp * 250 + 20, y);
                picturebox[index].Size = new Size(250, 250);
                picturebox[index].SizeMode = PictureBoxSizeMode.StretchImage;
                picturebox[index].Image = new Bitmap(streamList[index]);//Image.FromFile(list[index])
            }
        }

        private void PictureBoxClick(object sender, EventArgs e)
        {
            pictureBox1.Image = ((PictureBox)sender).Image;
        }

        private void setGalleryB()//on bing tab from disk
        {
            string[] list = Directory.GetFiles(@"./", "*.jpg");
            PictureBox[] picturebox = new PictureBox[list.Length];
            int y = -250, temp = 0;
            for (int index = 0; index < picturebox.Length; index++)
            {
                picturebox[index] = new PictureBox();
                tabPageInstagram.Controls.Add(picturebox[index]);
                // Following three lines set the images(picture boxes) locations
                if (index % 2 == 0)
                {
                    y = y + 250; // 3 images per rows
                    temp++;
                }
                else
                {
                    temp = 0;
                }
                picturebox[index].Location = new Point(temp * 250 + 20, y);

                picturebox[index].Size = new Size(250, 250);
                picturebox[index].SizeMode = PictureBoxSizeMode.StretchImage;
                picturebox[index].Image = Image.FromFile(list[index]);
            }
        }

        private void setGallery()//on form from disk
        {
            //--------------------------------
            // For confirm visibility of all images set 
            //this.AutoScroll = true;

            string[] list = Directory.GetFiles(@"./", "*.jpg");
            PictureBox[] picturebox = new PictureBox[list.Length];
            int y = -250, temp = 0;
            for (int index = 0; index < picturebox.Length; index++)
            {
                picturebox[index] = new PictureBox();
                this.Controls.Add(picturebox[index]);
                // Following three lines set the images(picture boxes) locations
                if (index % 2 == 0)
                {
                    y = y + 250; // 3 images per rows, first image will be at (20,150)
                    temp++;
                }
                else
                {
                    temp = 0;
                }
                picturebox[index].Location = new Point(temp * 250 + 20, y);

                picturebox[index].Size = new Size(250, 250);
                picturebox[index].SizeMode = PictureBoxSizeMode.StretchImage;
                picturebox[index].Image = Image.FromFile(list[index]);
            }
            //--------------------------------
        }

        private void buttonSetAsWallpaper_Click(object sender, EventArgs e)
        {
            String userPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            String picturesPath = userPath + "\\Pictures";
            String imageFile = "";
            if (System.IO.Directory.Exists(picturesPath))
            {
                imageFile = picturesPath + "\\wallpaper.jpg";
                pictureBox1.Image.Save(imageFile);
            } else
            {
                imageFile = userPath + "\\wallpaper.jpg";
                pictureBox1.Image.Save(imageFile);
            }
            if (Wallpaper.SetBackgroud(imageFile) >= 1)
            {
                //lbl_Info.Text = "Bingo, Wallpaper Set!!\n";
            }
            else
            {
                //lbl_Info.Text = "Error Setting Wallpaper!!";
            }
        }

        private void buttonSaveInstagram_Click(object sender, EventArgs e)
        {
            if(client.downloadInstagramImage(textBoxInstagramUrl.Text))
            {
                textBoxInstagramUrl.Text = "";
                MessageBox.Show("Your Instagram image is saved to database!", "Instagram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                setGalleryWithImages();
            }
            else
                MessageBox.Show("Instagram image not saved!", "Instagram", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
