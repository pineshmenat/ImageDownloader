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

        public static Image BinaryToImage(byte[] binaryData)
        {
            if (binaryData == null) return null;

            byte[] buffer = binaryData.ToArray();
            MemoryStream memStream = new MemoryStream();
            memStream.Write(buffer, 0, buffer.Length);
            return Image.FromStream(memStream);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                //List<ImageDownloadServiceReference.Image> bingWallpapers = client.getBingWallpapers().ToList<ImageDownloadServiceReference.Image>();

                //System.IO.Stream stream = new MemoryStream(bingWallpapers[0].image);
                //pictureBox1.Image = new Bitmap(stream);

                ////label1.Text = client.saveTodaysBingWallpaper().ToString();
                //label1.Text = client.downloadInstagramImage("https://p/BhIq1Xrjc2G/").ToString();

                try
                {
                    System.Net.WebRequest request =
                        System.Net.WebRequest.Create(
                        "https://www.gstatic.com/webp/gallery3/1.png");
                    System.Net.WebResponse response = request.GetResponse();
                    System.IO.Stream responseStream =
                        response.GetResponseStream();
                    Bitmap bitmap2 = new Bitmap(responseStream);
                    pictureBox1.Image = bitmap2;

                }
                catch (System.Net.WebException)
                {
                    MessageBox.Show("There was an error opening the image file."
                       + "Check the URL");
                }
            }
            catch (FaultException<ImageDownloadServiceReference.InvalidUrlFault> obj)
            {
                label1.Text = obj.Detail.Error + " " + obj.Detail.Details;
            }
        }
    }
}
