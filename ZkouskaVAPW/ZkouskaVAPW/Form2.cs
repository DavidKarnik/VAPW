using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZkouskaVAPW
{
    public partial class Form2 : Form
    {

        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(139, 325);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(350, 325);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 57);
            label1.Name = "label1";
            label1.Size = new Size(42, 25);
            label1.TabIndex = 2;
            label1.Text = "Text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 98);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 3;
            label2.Text = "Barva";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 141);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 4;
            label3.Text = "Souradnice X";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(135, 187);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 5;
            label4.Text = "Souradnice Y";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(165, 230);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 6;
            label5.Text = "Sirka";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(259, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(259, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(259, 138);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(259, 184);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(259, 227);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 11;
            // 
            // Form2
            // 
            ClientSize = new Size(669, 408);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;

        private Button button;

        public string TextBox1Text
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        //public Color ButtonColor
        //{
        //    get { return button.BackColor; }
        //    set { button.BackColor = value; }
        //}
        public string TextBox2Text
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public string TextBox3Text
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }

        public string TextBox4Text
        {
            get { return textBox4.Text; }
            set { textBox4.Text = value; }
        }
        public string TextBox5Text
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }

        public Form2(Button button)
        {
            InitializeComponent();
            this.button = button;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
