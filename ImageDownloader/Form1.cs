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
                List<ImageDownloadServiceReference.Image> bingWallpapers = client.getBingWallpapers().ToList<ImageDownloadServiceReference.Image>();

                System.IO.Stream stream = new MemoryStream(bingWallpapers[0].image);
                pictureBox1.Image = new Bitmap(stream);

                //label1.Text = client.saveTodaysBingWallpaper().ToString();
                //label1.Text = client.downloadInstagramImage("https:/www.instagram.com/p/BhIq1Xrjc2G/").ToString();

            }
            catch (FaultException<ImageDownloadServiceReference.InvalidUrlFault> obj)
            {
                label1.Text = obj.Detail.Error + " " + obj.Detail.Details;
            }
        }
    }
}
