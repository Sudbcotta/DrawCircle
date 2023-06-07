using System.Drawing;
using System.Windows.Forms;

namespace DrawCircle
{
    public partial class Form1 : Form
    {
        private List<Point> myPointList;
        public Form1()
        {
            InitializeComponent();
            myPointList = new List<Point>();
            
            
        }

        private void pnlPaint_MouseClick(object sender, MouseEventArgs e)
        {
            myPointList.Add(e.Location);
            pnlPaint.Invalidate();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gra = this.pnlPaint.CreateGraphics();
            Pen colorPen = new Pen(Color.Black, 4);

            

            foreach (Point point in myPointList)
            {
                
                criarTexto(point.X, point.Y);
                
                //public void FillEllipse(Brush brush, Rectangle rect)
                //{
                //    FillEllipse(brush, rect.X, rect.Y, rect.Width, rect.Height);
                //}
                gra.DrawEllipse(colorPen, point.X, point.Y, 10, 10);
                e.Graphics.FillEllipse(Brushes.Blue, point.X, point.Y, 10, 10);

                
            }
            
        }

        private void criarTexto(int pointX, int pointY)
        {
            var label1 = new Label();
            label1.Location = new Point(pointX, pointY);
            label1.Visible = true;
            label1.Text = "Creu";

            label1.ForeColor = Color.Black;
        }
    }
}