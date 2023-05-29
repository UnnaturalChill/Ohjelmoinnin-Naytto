namespace Ohjelmoinnin_Naytto
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
            textBox1 = new TextBox();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            listBox1 = new ListBox();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Cascadia Code", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(13, 13);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(639, 32);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDarkDark;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 60);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(662, 12);
            button1.Name = "button1";
            button1.Size = new Size(83, 32);
            button1.TabIndex = 1;
            button1.Text = "Luo";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(751, 12);
            button2.Name = "button2";
            button2.Size = new Size(83, 32);
            button2.TabIndex = 2;
            button2.Text = "Muokkaa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(840, 12);
            button3.Name = "button3";
            button3.Size = new Size(83, 32);
            button3.TabIndex = 3;
            button3.Text = "Poista";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(listBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(934, 501);
            panel1.TabIndex = 6;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(27, 27);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(879, 445);
            listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 561);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Panel panel1;
        private ListBox listBox1;
    }
}