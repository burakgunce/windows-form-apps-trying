namespace WinFormsApp4
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
            txtFilePath = new TextBox();
            btnSelectFile = new Button();
            ofdFile = new OpenFileDialog();
            btnWriteFile = new Button();
            btnReadFile = new Button();
            rtxtFileContent = new RichTextBox();
            SuspendLayout();
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(17, 19);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(360, 27);
            txtFilePath.TabIndex = 0;
            // 
            // btnSelectFile
            // 
            btnSelectFile.Location = new Point(412, 19);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(42, 29);
            btnSelectFile.TabIndex = 1;
            btnSelectFile.Text = "...";
            btnSelectFile.UseVisualStyleBackColor = true;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // ofdFile
            // 
            ofdFile.FileName = "openFileDialog1";
            // 
            // btnWriteFile
            // 
            btnWriteFile.Location = new Point(17, 74);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(136, 29);
            btnWriteFile.TabIndex = 2;
            btnWriteFile.Text = "Dosyaya Yaz";
            btnWriteFile.UseVisualStyleBackColor = true;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // btnReadFile
            // 
            btnReadFile.Location = new Point(251, 74);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(126, 29);
            btnReadFile.TabIndex = 3;
            btnReadFile.Text = "Dosyadan Oku";
            btnReadFile.UseVisualStyleBackColor = true;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // rtxtFileContent
            // 
            rtxtFileContent.Location = new Point(17, 137);
            rtxtFileContent.Name = "rtxtFileContent";
            rtxtFileContent.Size = new Size(437, 163);
            rtxtFileContent.TabIndex = 4;
            rtxtFileContent.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtxtFileContent);
            Controls.Add(btnReadFile);
            Controls.Add(btnWriteFile);
            Controls.Add(btnSelectFile);
            Controls.Add(txtFilePath);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilePath;
        private Button btnSelectFile;
        private OpenFileDialog ofdFile;
        private Button btnWriteFile;
        private Button btnReadFile;
        private RichTextBox rtxtFileContent;
    }
}