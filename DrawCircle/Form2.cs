using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawCircle
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int x;
        int y;
        Thread th;
        bool dragging = false;
        Rectangle r = new Rectangle(100, 100, 50, 50);
        Bitmap bmp;
        Graphics g;
        Graphics btg;
        Point cursor = Point.Empty;

        private void Form2_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(run);
            g = this.CreateGraphics();
            bmp = new Bitmap(this.Width, this.Height);
            btg = Graphics.FromImage(bmp);
            th.Start();
        }
        void run()
        {
            while (true)
            {
                btg.Clear(Color.Black);
                btg.FillEllipse(Brushes.Yellow, r);
                try
                {
                    g.DrawImage(bmp, Point.Empty);
                }
                catch { }
            }
        }

        private void Form2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            cursor.X = MousePosition.X - this.Location.X;
            cursor.Y = MousePosition.Y - this.Location.Y;

            if (dragging)
            {
                r.X = cursor.X + x;
                r.Y = cursor.Y + y;
            }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (r.Contains(cursor))
            {
                x = r.X - cursor.X;
                y = r.Y - cursor.Y;

                dragging = true;
            }
        }
    }
}
