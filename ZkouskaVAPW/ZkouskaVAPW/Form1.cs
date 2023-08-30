namespace ZkouskaVAPW
{
    public partial class Form1 : Form
    {

        public List<Button> buttons = new List<Button>();

        public Form1()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateButton(String text, String name, int x, int y)
        {
            Button newButton = new Button();
            newButton.Text = text;
            newButton.Location = new System.Drawing.Point(x, y);
            newButton.Size = new Size(150, 50);
            newButton.Name = name;
            this.Controls.Add(newButton);
            buttons.Add(newButton); // list
                                    // Add event handler
            newButton.Click += Button_Click;

            newButton.MouseEnter += GeneratedButton_MouseEnter;
        }

        private void DeleteButtons()
        {
            foreach (Button button in buttons)
            {
                this.Controls.Remove(button); // Remove each
            }
            buttons.Clear(); // Clear the list
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("0"))
            {
                this.Close();
            }

            int number;//= Int32.Parse(textBox1.Text);
            int.TryParse(textBox1.Text, out number);
            if (number > 0 && number < 26)
            {
                DeleteButtons();

                DateTime currentDateTime = DateTime.Now;
                string date = currentDateTime.ToString("MM-dd HH:mm:ss");
                string name = "";
                int x = 260;
                int y = 40;
                // size 150,50
                for (int i = 0; i < number; i++)
                {
                    if (i % 5 == 0)
                    {
                        y = y + 60;
                        x = 260;
                    }
                    name = i.ToString();
                    CreateButton(date, name, x, y);
                    x = x + 160;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            textBox2.Text = $"X: {e.X}, Y: {e.Y}";
        }

        //private void Button_Click(object sender, EventArgs e)
        //{
        //    Form2 myForm = new Form2();
        //    this.Hide();
        //    myForm.ShowDialog();
        //    this.Close();
        //}
        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Open the new Form2 for modifying the properties
            using (Form2 form2 = new Form2(clickedButton))
            {
                if (form2.ShowDialog() == DialogResult.OK)
                {
                    // Update the button properties
                    // text, barva, x, y, sirka
                    clickedButton.Text = form2.TextBox1Text;
                    //clickedButton.BackColor = form2.TextBox2Text;
                    if (!string.IsNullOrEmpty(form2.TextBox5Text))
                    {
                        clickedButton.Size = new Size(150, Int16.Parse(form2.TextBox5Text));
                    }

                    if (!string.IsNullOrEmpty(form2.TextBox3Text) && !string.IsNullOrEmpty(form2.TextBox4Text))
                    {
                        clickedButton.Location = new Point(int.Parse(form2.TextBox3Text), int.Parse(form2.TextBox4Text));
                    }

                        // newButton.Size = new Size(150, 50);
                        
                    //clickedButton.BackColor = form2.ButtonColor;
                    if (!string.IsNullOrEmpty(form2.TextBox2Text))
                    {
                        try
                        {
                            Color buttonColor = ColorTranslator.FromHtml(form2.TextBox2Text);
                            clickedButton.BackColor = buttonColor;
                        }
                        catch (Exception ex)
                        {
                            // Handle any exception that might occur while converting the color
                            MessageBox.Show("Invalid color value entered.");
                        }
                    }
                }
            }
        }

        // mouse on button
        private void GeneratedButton_MouseEnter(object sender, EventArgs e)
        {
            Button enteredButton = (Button)sender;

            // Update TextBox2 with the location of the button
            textBox3.Text = $"X: {enteredButton.Location.X}, Y: {enteredButton.Location.Y}";
        }

    }
}