namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x = 0;
        int y = 0;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //this.Cursor = new Cursor(Cursor.Current.Handle);
            //Cursor.Position = new Point(Cursor.Position.X - 50, Cursor.Position.Y - 50);
            //Cursor.Clip = new Rectangle(this.Location, this.Size);
            Graphics g = panel1.CreateGraphics();
            //g.DrawLine(new Pen(Color.Red, 4), new Point(0, 0), new Point(Cursor.Position.X, Cursor.Position.Y));
            //g.DrawLine(new Pen(Color.Red, 4), new Point(panel1.Width, panel1.Height), new Point(Cursor.Position.X, Cursor.Position.Y));
            //g.DrawLine(new Pen(Color.Red, 4), new Point(panel1.Width, 0), new Point(Cursor.Position.X, Cursor.Position.Y));
            //g.DrawLine(new Pen(Color.Red, 4), new Point(0, panel1.Height), new Point(Cursor.Position.X, Cursor.Position.Y));

            g.DrawLine(new Pen(Color.Red, 4), new Point(0, 0), new Point(x, y));
            g.DrawLine(new Pen(Color.Red, 4), new Point(panel1.Width, panel1.Height), new Point(x, y));
            g.DrawLine(new Pen(Color.Red, 4), new Point(panel1.Width, 0), new Point(x, y));
            g.DrawLine(new Pen(Color.Red, 4), new Point(0, panel1.Height), new Point(x, y));
            //panel1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Thread ? start ?
        }

        private void Tracker()
        {
            //int x = MousePosition.X;
            //int y = MousePosition.Y;
        }

        private void panel1_MouseMove_1(object sender, MouseEventArgs e)
        {
            //Graphics g = panel1.CreateGraphics();
            //g.DrawLine(new Pen(Color.Red, 4), new Point(0, 0), new Point(e.X, e.Y));
            //g.DrawLine(new Pen(Color.Red, 4), new Point(panel1.Width, panel1.Height), new Point(e.X, e.Y));
            //g.DrawLine(new Pen(Color.Red, 4), new Point(panel1.Width, 0), new Point(e.X, e.Y));
            //g.DrawLine(new Pen(Color.Red, 4), new Point(0, panel1.Height), new Point(e.X, e.Y));
            x = e.X;
            y = e.Y;
            //panel1.Invalidate();
            panel1.Refresh();
            textBoxX.Text = x.ToString();
            textBoxY.Text = y.ToString();
            //panel1.Update();

        }

        private void textBoxX_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxY_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}