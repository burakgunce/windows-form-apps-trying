namespace WinFormsApp5
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
            ogrenciListesi = new ListBox();
            SuspendLayout();
            // 
            // ogrenciListesi
            // 
            ogrenciListesi.FormattingEnabled = true;
            ogrenciListesi.ItemHeight = 20;
            ogrenciListesi.Location = new Point(14, 24);
            ogrenciListesi.Name = "ogrenciListesi";
            ogrenciListesi.Size = new Size(295, 404);
            ogrenciListesi.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 450);
            Controls.Add(ogrenciListesi);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private ListBox ogrenciListesi;
    }
}