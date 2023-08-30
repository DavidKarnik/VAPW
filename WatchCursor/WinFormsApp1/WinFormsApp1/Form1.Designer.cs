namespace WinFormsApp1
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
            panel1 = new Panel();
            textBoxX = new TextBox();
            textBoxY = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(40, 40);
            panel1.Name = "panel1";
            panel1.Size = new Size(830, 619);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseMove += panel1_MouseMove_1;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(989, 157);
            textBoxX.Name = "textBoxX";
            textBoxX.ReadOnly = true;
            textBoxX.Size = new Size(157, 31);
            textBoxX.TabIndex = 1;
            textBoxX.TextChanged += textBoxX_TextChanged;
            // 
            // textBoxY
            // 
            textBoxY.Location = new Point(989, 245);
            textBoxY.Name = "textBoxY";
            textBoxY.ReadOnly = true;
            textBoxY.Size = new Size(157, 31);
            textBoxY.TabIndex = 2;
            textBoxY.TextChanged += textBoxY_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(942, 154);
            label1.Name = "label1";
            label1.Size = new Size(44, 32);
            label1.TabIndex = 3;
            label1.Text = "X :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(942, 242);
            label2.Name = "label2";
            label2.Size = new Size(43, 32);
            label2.TabIndex = 4;
            label2.Text = "Y :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1360, 721);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxY);
            Controls.Add(textBoxX);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "WatchCursor";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBoxY;
        private Label label1;
        private Label label2;
        public TextBox textBoxX;
    }
}