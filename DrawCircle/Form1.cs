using System.Drawing;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Windows.Forms;

namespace DrawCircle
{
    public partial class Form1 : Form
    {
        int ptX;
        int ptY;
        int ver;
        private List<Point> myPointList;
        public Form1()
        {
            InitializeComponent();
            myPointList = new List<Point>();
        }


        bool dragging = false;

        Bitmap btm;

        Graphics g;
        Graphics btg;

        Point cursor = Point.Empty;



        private void pnlPaint_MouseClick(object sender, MouseEventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private Label criarTexto(int ptX, int ptY)
        {
            var mLb = new Label();
            mLb.Location = new Point(ptX, ptY);
            mLb.Visible = true;
            mLb.Text = ($"MXR_{ver}");
            mLb.Font = new Font("Calibri", 10);
            mLb.ForeColor = Color.Black;
            mLb.BackColor = System.Drawing.Color.Transparent;
            mLb.Margin = new Padding(0);
            mLb.Padding = new Padding(0);
            mLb.Size = new Size(60, 17);
            mLb.Draggable(true);
            return mLb;
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            ptX = e.X;
            ptY = e.Y;
            myPointList.Add(e.Location);
            Label a = criarTexto(ptX + 10, ptY + 10);
            pictureBox1.Controls.Add(a);
            pictureBox1.Invalidate();
            ver = ver + 1;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gra = this.pictureBox1.CreateGraphics();
            Pen colorPen = new Pen(Color.Blue, 4);

            foreach (Point point in myPointList)
            {

                //public void FillEllipse(Brush brush, Rectangle rect)
                //{
                //    FillEllipse(brush, rect.X, rect.Y, rect.Width, rect.Height);
                //}
                gra.DrawEllipse(colorPen, point.X, point.Y, 10, 10);
                gra.FillEllipse(Brushes.Blue, point.X, point.Y, 10, 10);


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}