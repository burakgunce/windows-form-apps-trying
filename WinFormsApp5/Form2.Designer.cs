namespace WinFormsApp5
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            öğrenciEkleToolStripMenuItem = new ToolStripMenuItem();
            öğrenciListeleToolStripMenuItem = new ToolStripMenuItem();
            groupBox1 = new GroupBox();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { öğrenciEkleToolStripMenuItem, öğrenciListeleToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(366, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // öğrenciEkleToolStripMenuItem
            // 
            öğrenciEkleToolStripMenuItem.Name = "öğrenciEkleToolStripMenuItem";
            öğrenciEkleToolStripMenuItem.Size = new Size(106, 24);
            öğrenciEkleToolStripMenuItem.Text = "Öğrenci Ekle";
            // 
            // öğrenciListeleToolStripMenuItem
            // 
            öğrenciListeleToolStripMenuItem.Name = "öğrenciListeleToolStripMenuItem";
            öğrenciListeleToolStripMenuItem.Size = new Size(121, 24);
            öğrenciListeleToolStripMenuItem.Text = "Öğrenci Listele";
            öğrenciListeleToolStripMenuItem.Click += öğrenciListeleToolStripMenuItem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(44, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(274, 214);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Ekleme Ekranı";
            // 
            // button1
            // 
            button1.Location = new Point(53, 133);
            button1.Name = "button1";
            button1.Size = new Size(175, 52);
            button1.TabIndex = 2;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(175, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 45);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 0;
            label1.Text = "Adı Soyadı";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 293);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form2";
            Text = "Form2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem öğrenciEkleToolStripMenuItem;
        private ToolStripMenuItem öğrenciListeleToolStripMenuItem;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
    }
}