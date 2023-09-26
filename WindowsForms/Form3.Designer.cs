namespace WindowsForms
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
            txtGirilenMetin = new TextBox();
            lblKalanKarakter = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtGirilenMetin
            // 
            txtGirilenMetin.Location = new Point(90, 30);
            txtGirilenMetin.Multiline = true;
            txtGirilenMetin.Name = "txtGirilenMetin";
            txtGirilenMetin.Size = new Size(429, 195);
            txtGirilenMetin.TabIndex = 0;
            txtGirilenMetin.TextChanged += txtGirilenMetin_TextChanged;
            // 
            // lblKalanKarakter
            // 
            lblKalanKarakter.AutoSize = true;
            lblKalanKarakter.Location = new Point(90, 241);
            lblKalanKarakter.Name = "lblKalanKarakter";
            lblKalanKarakter.Size = new Size(153, 20);
            lblKalanKarakter.TabIndex = 1;
            lblKalanKarakter.Text = "Kalan Karakter Sayısı :";
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 241);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 2;
            label1.Text = "500";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblKalanKarakter);
            Controls.Add(txtGirilenMetin);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtGirilenMetin;
        private Label lblKalanKarakter;
        private Label label1;
    }
}