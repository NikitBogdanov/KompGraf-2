using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Printing;

namespace KompGraf_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.BackColor = Color.FromKnownColor(KnownColor.AliceBlue);
        }
        private void Pixel_Click(object sender, EventArgs e)
        {
            DrawSystem();

            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.FromArgb(9, 167, 172), 3f);
            graphics.PageUnit = GraphicsUnit.Pixel;

            Random random = new Random();

            Point p1 = new Point(pictureBox1.Width/2 + random.Next(-100, 100), pictureBox1.Height/2 + (3 * random.Next(-100, 100) + 1));
            Point p2 = new Point(pictureBox1.Width / 2 + random.Next(-100, 100), pictureBox1.Height / 2 + (3 * random.Next(-100, 100) + 1));
            graphics.DrawLine(pen, p1, p2);
        }

        private void Millimeter_Click(object sender, EventArgs e)
        {
            DrawSystem();

            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.FromArgb(185, 41, 5), 1f);
            graphics.PageUnit = GraphicsUnit.Millimeter;

            Random random = new Random();

            int widthCentr = (int)((pictureBox1.Width / 2) / 3.793627);
            int heightCentr = (int)((pictureBox1.Height / 2) / 3.793627);
            Point p1 = new Point(widthCentr + (int)(random.Next(-100, 100) / 3.793627), heightCentr + (int)((3 * random.Next(-100, 100) + 1) / 3.793627));
            Point p2 = new Point(widthCentr + (int)(random.Next(-100, 100) / 3.793627), heightCentr + (int)((3 * random.Next(-100, 100) + 1) / 3.793627));
            graphics.DrawLine(pen, p1, p2);
        }

        private void Inch_Click(object sender, EventArgs e)
        {
            DrawSystem();

            Graphics graphics = pictureBox1.CreateGraphics();
            Pen pen = new Pen(Color.FromArgb(98, 6, 121), 0.05f);
            graphics.PageUnit = GraphicsUnit.Inch;

            Random random = new Random();

            int widthCentr = (int)((pictureBox1.Width / 2) / 96.358115);
            int heightCentr = (int)((pictureBox1.Height / 2) / 96.358115);
            Point p1 = new Point(widthCentr + (int)(random.Next(-200, 200) / 96.358115), heightCentr + (int)((3 * random.Next(-200, 200) + 1) / 96.358115));
            Point p2 = new Point(widthCentr + (int)(random.Next(-200, 200) / 96.358115), heightCentr + (int)((3 * random.Next(-200, 200) + 1) / 96.358115));
            graphics.DrawLine(pen, p1, p2);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.FromKnownColor(KnownColor.AliceBlue));
        }

        private void DrawSystem()
        {
            Graphics graphics = pictureBox1.CreateGraphics();
            Pen myPen = new Pen(Color.Black, 2f);
            graphics.DrawLine(myPen, new Point(pictureBox1.Width / 2, 0), new Point(pictureBox1.Width / 2, pictureBox1.Height));
            graphics.DrawLine(myPen, new Point(0, pictureBox1.Height / 2), new Point(pictureBox1.Width, pictureBox1.Height / 2));
            graphics.DrawRectangle(myPen, 0, 0, pictureBox1.Size.Width - 1, pictureBox1.Size.Height - 1);
        }
    }
}
