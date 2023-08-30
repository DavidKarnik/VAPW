namespace Game
{
    public partial class Form1 : Form
    {
        postava aa = new postava("Bojovnik 1");
        postava bb = new postava("Bojovnik 2");

        public Form1()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("0 HP"))
            {
                textBox1.BackColor = Color.Red;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Equals("0 HP"))
            {
                textBox2.BackColor = Color.Red;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aa.attack(bb);
            bb.attack(aa);
            textBox1.Text = aa.getHP() + " HP";
            textBox2.Text = bb.getHP() + " HP";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            textBox1.BackColor = Color.White;

            aa.setHP(100);
            bb.setHP(100);

            textBox1.Text = "100 HP";
            textBox2.Text = "100 HP";

        }

        private void leaderBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void setHPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aa.setHP(50);
            bb.setHP(50);
        }
    }
}