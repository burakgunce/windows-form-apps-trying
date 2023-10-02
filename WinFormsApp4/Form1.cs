namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            DialogResult result =
            ofdFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFilePath.Text = ofdFile.FileName;
            }

            // Text Dosyasý(*.txt)|.txt|Winrar Dosyaalarý(*.rar)|.rar|Tüm Dosyalar(*.*)|*.*
            //bu ofd nin filtre bölümüne yazýlýrsa sadece bu dosyalarý ekleyebiliyor kullanýcý.
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            StreamReader strRead = new StreamReader(txtFilePath.Text);

            string str = strRead.ReadToEnd();

            rtxtFileContent.Text = str;

            strRead.Close(); // dosyayla baglantýyý kesip baþka bir seçimde hata almamak için

        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            StreamWriter strWrite = new StreamWriter(txtFilePath.Text);
            strWrite.Write(rtxtFileContent.Text);
            strWrite.Close();
            rtxtFileContent.Clear();
        }

        // File Stream
        //FileStream sýnýfý ile diskte bulunan bir dosyaya ulaþým saðlayabiliriz.
        //StreamWriter ve StreamReader ile açýlan bir dosya üzerinde yazma ve okuma iþlemleri yapýlabilir
        /* dosya uzerýnde metýn tabanlý veya byte table tabanlý ýslemler yapýlaýblýr
         * Read() ya da ReadByte() metotlarý byte dueyýnde verý okumamýzý saglayan metodlardýr.
         * ReadByte() okuma yapmaz ile -1 döndurur.
         * 
         */
    }
}