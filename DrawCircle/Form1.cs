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
            Pen colorPen = new Pen(Color.Red, 1);

            //Rectangle r = new Rectangle(10, 10, 8, 8);
            //PointF pnt1 = new PointF(100.0F, 100.0F);
            //PointF pnt2 = new PointF(300.0F, 300.0F);
            foreach (Point point in myPointList)
            {
                //public void FillEllipse(Brush brush, Rectangle rect)
                //{
                //    FillEllipse(brush, rect.X, rect.Y, rect.Width, rect.Height);
                //}
                gra.DrawEllipse(colorPen, point.X, point.Y, 10,10);
                e.Graphics.FillEllipse(Brushes.Red,point.X,point.Y,10,10);
            }
            
        }
    }
}