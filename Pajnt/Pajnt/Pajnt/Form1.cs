using AForge.Imaging.Filters;
using System;
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

            g.Clear(Color.White);
            pbImage.Refresh();

            while (true)
            {
                if (image.Width <= pbImage.Width && image.Height <= pbImage.Height)
                {
                    g.DrawImage(image, 0, 0, image.Width, image.Height);
                    break;
                }
                else
                {
                    g.DrawImage(image, 0, 0, image.Width/2, image.Height/2);
                    break;
                }
            }

            pbImage.Image = drawArea;
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pbImage.Refresh();
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
          
            save.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            if (save.ShowDialog() == DialogResult.OK)
            {
                reset();
                if(image != null)
                image.Dispose();

                if (System.IO.File.Exists(save.FileName))
                    System.IO.File.Delete(save.FileName);

                drawArea.Save(save.FileName, ImageFormat.Jpeg);
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

        private void filtr1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grayscale grayscale = new Grayscale(0.2126, 0.7152, 0.0722);
            drawArea = grayscale.Apply(drawArea);
            pbImage.Image = drawArea;
            reset();         
        }


        private void filtr2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sepia sepia = new Sepia();
            drawArea = sepia.Apply(drawArea);
            pbImage.Image = drawArea;
            reset();
        }

        private void pbImage_Click(object sender, EventArgs e)
        {

        }

        private void filtr3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Blur blur = new Blur();
            drawArea = blur.Apply(drawArea);
            pbImage.Image = drawArea;
            reset();
        }

        private void panel1_SizeChanged(object sender, EventArgs e)
        {
          
        }

        private void tableLayoutPanel1_Resize(object sender, EventArgs e)
        {
            pbImage.Width = tableLayoutPanel1.Width;
            pbImage.Height = tableLayoutPanel1.Height;
        }

        private void pbImage_SizeChanged(object sender, EventArgs e)
        {
            reset();
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

        private void reset()
        {
            Image screenCopy = pbImage.Image;
            drawArea = new Bitmap(pbImage.Width, pbImage.Height);
            g = Graphics.FromImage(drawArea);
            g.DrawImage(screenCopy, 0, 0, pbImage.Width, pbImage.Height);
            pbImage.Image = drawArea;

        }

    }


}
