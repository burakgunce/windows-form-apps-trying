namespace WinFormsApp3
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            label2 = new Label();
            progressBar1 = new ProgressBar();
            label3 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(510, 67);
            button1.TabIndex = 0;
            button1.Text = "Oyunu Başlat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 99);
            label1.Name = "label1";
            label1.Size = new Size(156, 20);
            label1.TabIndex = 1;
            label1.Text = "1-100 arası sayı giriniz";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(221, 96);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 27);
            textBox1.TabIndex = 2;
            // 
            // button2
            // 
            button2.Location = new Point(12, 139);
            button2.Name = "button2";
            button2.Size = new Size(510, 62);
            button2.TabIndex = 3;
            button2.Text = "Tahmin Et";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(32, 217);
            label2.Name = "label2";
            label2.Size = new Size(2, 22);
            label2.TabIndex = 4;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 258);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(510, 26);
            progressBar1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 298);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 6;
            label3.Text = "label3";
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 351);
            Controls.Add(label3);
            Controls.Add(progressBar1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Button button2;
        private Label label2;
        private ProgressBar progressBar1;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}