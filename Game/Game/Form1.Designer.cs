namespace Game
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            menu1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            leaderBoardToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            setHPToolStripMenuItem = new ToolStripMenuItem();
            setPowerToolStripMenuItem = new ToolStripMenuItem();
            hPToolStripMenuItem = new ToolStripMenuItem();
            hPToolStripMenuItem1 = new ToolStripMenuItem();
            hPToolStripMenuItem2 = new ToolStripMenuItem();
            hPToolStripMenuItem3 = new ToolStripMenuItem();
            menu1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(144, 157);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(171, 44);
            textBox1.TabIndex = 0;
            textBox1.Text = "100 HP";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(856, 157);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(171, 44);
            textBox2.TabIndex = 1;
            textBox2.Text = "100 HP";
            textBox2.TextAlign = HorizontalAlignment.Center;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(448, 294);
            button1.Name = "button1";
            button1.Size = new Size(280, 100);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.InactiveCaption;
            label1.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(144, 98);
            label1.Name = "label1";
            label1.Size = new Size(172, 37);
            label1.TabIndex = 3;
            label1.Text = "Postava A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.InactiveCaption;
            label2.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(856, 98);
            label2.Name = "label2";
            label2.Size = new Size(171, 37);
            label2.TabIndex = 4;
            label2.Text = "Postava B";
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(448, 410);
            button2.Name = "button2";
            button2.Size = new Size(280, 100);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // menu1
            // 
            menu1.BackColor = SystemColors.GradientActiveCaption;
            menu1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menu1.ImageScalingSize = new Size(24, 24);
            menu1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, settingsToolStripMenuItem });
            menu1.Location = new Point(0, 0);
            menu1.Name = "menu1";
            menu1.Size = new Size(1141, 40);
            menu1.TabIndex = 6;
            menu1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { leaderBoardToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(96, 36);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // leaderBoardToolStripMenuItem
            // 
            leaderBoardToolStripMenuItem.Name = "leaderBoardToolStripMenuItem";
            leaderBoardToolStripMenuItem.Size = new Size(270, 40);
            leaderBoardToolStripMenuItem.Text = "Leader Board";
            leaderBoardToolStripMenuItem.Click += leaderBoardToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { setHPToolStripMenuItem, setPowerToolStripMenuItem });
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(122, 36);
            settingsToolStripMenuItem.Text = "Settings";
            // 
            // setHPToolStripMenuItem
            // 
            setHPToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hPToolStripMenuItem, hPToolStripMenuItem1, hPToolStripMenuItem2, hPToolStripMenuItem3 });
            setHPToolStripMenuItem.Name = "setHPToolStripMenuItem";
            setHPToolStripMenuItem.Size = new Size(270, 40);
            setHPToolStripMenuItem.Text = "Set HP";
            setHPToolStripMenuItem.Click += setHPToolStripMenuItem_Click;
            // 
            // setPowerToolStripMenuItem
            // 
            setPowerToolStripMenuItem.Name = "setPowerToolStripMenuItem";
            setPowerToolStripMenuItem.Size = new Size(270, 40);
            setPowerToolStripMenuItem.Text = "Set Power";
            // 
            // hPToolStripMenuItem
            // 
            hPToolStripMenuItem.Name = "hPToolStripMenuItem";
            hPToolStripMenuItem.Size = new Size(270, 40);
            hPToolStripMenuItem.Text = "50 HP";
            hPToolStripMenuItem.Click += hPToolStripMenuItem_Click;
            // 
            // hPToolStripMenuItem1
            // 
            hPToolStripMenuItem1.Name = "hPToolStripMenuItem1";
            hPToolStripMenuItem1.Size = new Size(270, 40);
            hPToolStripMenuItem1.Text = "100 HP";
            // 
            // hPToolStripMenuItem2
            // 
            hPToolStripMenuItem2.Name = "hPToolStripMenuItem2";
            hPToolStripMenuItem2.Size = new Size(270, 40);
            hPToolStripMenuItem2.Text = "200 HP";
            // 
            // hPToolStripMenuItem3
            // 
            hPToolStripMenuItem3.Name = "hPToolStripMenuItem3";
            hPToolStripMenuItem3.Size = new Size(270, 40);
            hPToolStripMenuItem3.Text = "500 HP";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1141, 611);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(menu1);
            MainMenuStrip = menu1;
            Name = "Form1";
            Text = "Game";
            menu1.ResumeLayout(false);
            menu1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private MenuStrip menu1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem leaderBoardToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem setHPToolStripMenuItem;
        private ToolStripMenuItem setPowerToolStripMenuItem;
        private ToolStripMenuItem hPToolStripMenuItem;
        private ToolStripMenuItem hPToolStripMenuItem1;
        private ToolStripMenuItem hPToolStripMenuItem2;
        private ToolStripMenuItem hPToolStripMenuItem3;
    }
}