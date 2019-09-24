﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Mini_istanbul
{
    public partial class FrmHarita : Form
    {
        public FrmHarita()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Image img = pictureBox1.Image;
            int zoomwidth = pictureBox1.Width;
            int zoomheight = pictureBox1.Height;
            if (img.Width <= (e.X + zoomwidth))
            {
                zoomwidth = img.Width - e.X;
            }
            if (img.Height <= (e.Y + zoomheight))
            {
                zoomheight = img.Height - e.Y;
            }
            Rectangle rec = new Rectangle(e.X, e.Y, zoomwidth, zoomheight);
            pictureBox2.Image = cropImage(img, rec);
           
        }
        private Image cropImage(Image img, Rectangle croparea)
        {
            Bitmap bmpimage = new Bitmap(img);
            Bitmap bmpcrop = bmpimage.Clone(croparea, bmpimage.PixelFormat);
            return (Image)(bmpcrop);

        }
    }
}
