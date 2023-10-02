namespace WinFormsApp4
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
            btnDrive = new Button();
            btnDirectory = new Button();
            btnKlasorIslemleri = new Button();
            btnDirectories = new Button();
            btnFiles = new Button();
            lstDirectory = new ListBox();
            lstFiles = new ListBox();
            btnDosyaKopyala = new Button();
            btnKlasorKopyala = new Button();
            SuspendLayout();
            // 
            // btnDrive
            // 
            btnDrive.Location = new Point(24, 26);
            btnDrive.Name = "btnDrive";
            btnDrive.Size = new Size(150, 29);
            btnDrive.TabIndex = 0;
            btnDrive.Text = "Sürücü Bilgileri";
            btnDrive.UseVisualStyleBackColor = true;
            btnDrive.Click += btnDrive_Click;
            // 
            // btnDirectory
            // 
            btnDirectory.Location = new Point(218, 26);
            btnDirectory.Name = "btnDirectory";
            btnDirectory.Size = new Size(125, 29);
            btnDirectory.TabIndex = 1;
            btnDirectory.Text = "Klasör Bilgileri";
            btnDirectory.UseVisualStyleBackColor = true;
            btnDirectory.Click += btnDirectory_Click;
            // 
            // btnKlasorIslemleri
            // 
            btnKlasorIslemleri.Location = new Point(380, 26);
            btnKlasorIslemleri.Name = "btnKlasorIslemleri";
            btnKlasorIslemleri.Size = new Size(139, 29);
            btnKlasorIslemleri.TabIndex = 2;
            btnKlasorIslemleri.Text = "Klasör İşlemleri";
            btnKlasorIslemleri.UseVisualStyleBackColor = true;
            btnKlasorIslemleri.Click += btnKlasorIslemleri_Click;
            // 
            // btnDirectories
            // 
            btnDirectories.Location = new Point(27, 82);
            btnDirectories.Name = "btnDirectories";
            btnDirectories.Size = new Size(147, 29);
            btnDirectories.TabIndex = 3;
            btnDirectories.Text = "Klasör Listesi";
            btnDirectories.UseVisualStyleBackColor = true;
            btnDirectories.Click += btnDirectories_Click;
            // 
            // btnFiles
            // 
            btnFiles.Location = new Point(218, 82);
            btnFiles.Name = "btnFiles";
            btnFiles.Size = new Size(125, 29);
            btnFiles.TabIndex = 4;
            btnFiles.Text = "Dosya Listesi";
            btnFiles.UseVisualStyleBackColor = true;
            btnFiles.Click += btnFiles_Click;
            // 
            // lstDirectory
            // 
            lstDirectory.FormattingEnabled = true;
            lstDirectory.ItemHeight = 20;
            lstDirectory.Location = new Point(26, 132);
            lstDirectory.Name = "lstDirectory";
            lstDirectory.Size = new Size(156, 304);
            lstDirectory.TabIndex = 5;
            // 
            // lstFiles
            // 
            lstFiles.FormattingEnabled = true;
            lstFiles.ItemHeight = 20;
            lstFiles.Location = new Point(221, 133);
            lstFiles.Name = "lstFiles";
            lstFiles.Size = new Size(156, 304);
            lstFiles.TabIndex = 6;
            // 
            // btnDosyaKopyala
            // 
            btnDosyaKopyala.Location = new Point(397, 82);
            btnDosyaKopyala.Name = "btnDosyaKopyala";
            btnDosyaKopyala.Size = new Size(122, 29);
            btnDosyaKopyala.TabIndex = 7;
            btnDosyaKopyala.Text = "Dosya Kopyala";
            btnDosyaKopyala.UseVisualStyleBackColor = true;
            btnDosyaKopyala.Click += btnDosyaKopyala_Click;
            // 
            // btnKlasorKopyala
            // 
            btnKlasorKopyala.Location = new Point(397, 132);
            btnKlasorKopyala.Name = "btnKlasorKopyala";
            btnKlasorKopyala.Size = new Size(122, 29);
            btnKlasorKopyala.TabIndex = 8;
            btnKlasorKopyala.Text = "Klasör Kopyala";
            btnKlasorKopyala.UseVisualStyleBackColor = true;
            btnKlasorKopyala.Click += btnKlasorKopyala_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 450);
            Controls.Add(btnKlasorKopyala);
            Controls.Add(btnDosyaKopyala);
            Controls.Add(lstFiles);
            Controls.Add(lstDirectory);
            Controls.Add(btnFiles);
            Controls.Add(btnDirectories);
            Controls.Add(btnKlasorIslemleri);
            Controls.Add(btnDirectory);
            Controls.Add(btnDrive);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDrive;
        private Button btnDirectory;
        private Button btnKlasorIslemleri;
        private Button btnDirectories;
        private Button btnFiles;
        private ListBox lstDirectory;
        private ListBox lstFiles;
        private Button btnDosyaKopyala;
        private Button btnKlasorKopyala;
    }
}