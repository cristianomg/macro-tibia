using Screens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Screenshot
{
    public partial class Save : Form
    {
        private HomePage HomePage;
        private string ImageName;
        Bitmap bmp;
        public Save(HomePage homePage, string imageName, Int32 x, Int32 y, Int32 w, Int32 h, Size s)
        {
            InitializeComponent();
            Rectangle rect = new Rectangle(x, y, w, h);
            bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, s, CopyPixelOperation.SourceCopy);
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{imageName}.jpg");
            bmp.Save(path, System.Drawing.Imaging.ImageFormat.Jpeg);
            pbCapture.Image = bmp;
            this.HomePage = homePage;
            this.ImageName = imageName;

            if (ImageName == "Healing")
            {
                homePage.Configs.Healing = rect;

                homePage.Configs.ToFile();
            }

        }
        private void formEvent_closing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            HomePage.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var selectArea = new SelectArea(HomePage, ImageName);
            this.Hide();
            selectArea.Show();
        }
    }
}
