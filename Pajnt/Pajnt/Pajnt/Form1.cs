﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pajnt
{
    public partial class Form1 : Form
    {

        Graphics g;
        Pen pen;
        Bitmap drawArea;
        Image image;
        Color c;
        int w, h, dw, dh;

        public Form1()
        {
            InitializeComponent();
            drawArea = new Bitmap(pbImage.Size.Width, pbImage.Size.Height);
            pbImage.Image = drawArea;
            g = Graphics.FromImage(drawArea);
            c = Color.Black;
            pen = new Pen(c, float.Parse(tbRozmiar.Text));
            g.Clear(Color.White);
            pbImage.Refresh();
            pbImage.BackgroundImageLayout = ImageLayout.Stretch;
            w = this.Size.Width;
            h = this.Size.Height;
            dw = 0; dh = 0;

        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Files|*.jpg;*.jpeg;";
            dialog.ShowDialog();
            image = new Bitmap(dialog.FileName);


        if(image.Width <= pbImage.Width && image.Height <= pbImage.Height)
            {
                g.DrawImage(image, 0, 0, image.Width, image.Height);
            }

            pbImage.Image = drawArea;
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pbImage.Image = g.DrawRectangle
            g.Clear(Color.White);
            pbImage.Refresh();
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "Files|*.jpg;*.jpeg;";
            if(save.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image.Save(save.FileName, ImageFormat.Jpeg);
            }

        }

        private void pbImage_MouseMove(object sender, MouseEventArgs e)
        {

            int x = 0, y = 0;

            if (e.Button == MouseButtons.Left)
            {          
                g.FillEllipse(pen.Brush,e.X, e.Y, pen.Width, pen.Width);
                pbImage.Image = drawArea;
            }
        }

        private void bColor_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            dialog.ShowDialog();
            c = dialog.Color;
            pen = new Pen(c, float.Parse(tbRozmiar.Text));
        }

        private void tbRozmiar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                pen = new Pen(c, float.Parse(tbRozmiar.Text));
            } catch (Exception)
            {
                tbRozmiar.Text = "10";
                MessageBox.Show("Tylko liczby!");
            }
        }

        private void menuStrip1_SizeChanged(object sender, EventArgs e)
        {
            
        }
    }


}