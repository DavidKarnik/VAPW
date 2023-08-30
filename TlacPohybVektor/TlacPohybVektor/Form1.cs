using System.Runtime.ExceptionServices;

namespace TlacPohybVektor
{
    public partial class Form1 : Form
    {
        int cnt;
        int startTick;
        // mouse
        int dx, dy;
        int mujposun;
        int novex, novey;
        Point first;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cnt++;
            label1.Text = cnt.ToString();
            //first = new Point(button1.Location.X + button1.Width / 2, button1.Location.Y + button1.Height / 2);
            //first = button1.Location;
            first = new Point(button1.Location.X, button1.Location.Y);
            button1.Location = new Point(first.X + novex / 10, first.Y + novey / 10);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //timer1.Enabled = !timer1.Enabled;
            //if (timer1.Enabled)
            //{
            //    startTick = Environment.TickCount; //poèet sekund od startu systému
            //}
            //else
            //{
            //    // timer1.Interval je v ms
            //    label1.Text = string.Format("Pocet udalosti {0} s intervalem {1} zabralo {2} ms",
            //        cnt, timer1.Interval, Environment.TickCount - startTick);
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Location = new Point((this.Width / 2) - (button1.Width / 2), (this.Height / 2) - (button1.Height / 2));
            //int formHeight = this.Height;
            //int formWidth = this.Width;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            dx = e.X;
            dy = e.Y;
            label2.Text = string.Format("Pozice mysi dx: {0}, dy: {1}", dx, dy);
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled)
            {
                startTick = Environment.TickCount; //poèet sekund od startu systému
            }
            else
            {
                // timer1.Interval je v ms
                label1.Text = string.Format("Pocet udalosti {0} s intervalem {1} zabralo {2} ms",
                    cnt, timer1.Interval, Environment.TickCount - startTick);
            }
            first = button1.Location;
            //mujposun = Convert.ToInt16(Math.Sqrt(Math.Pow((first.X - dx), 2) + Math.Pow((first.Y - dy), 2)));
            int mujposunx = Convert.ToInt16(Math.Sqrt(Math.Pow((first.X - dx), 2)));
            int mujposuny = Convert.ToInt16(Math.Sqrt(Math.Pow((first.Y - dy), 2)));
            //Point posun = new Point(dx, dy);
            if (dx < first.X)
            {
                novex = -mujposunx;
            }
            else
            {
                novex = mujposunx;
            }
            if (dy < first.Y)
            {
                novey = -mujposuny;
            }
            else
            {
                novey = mujposuny;
            }
        }
    }
}