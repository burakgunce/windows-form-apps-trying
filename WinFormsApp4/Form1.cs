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

            // Text Dosyas�(*.txt)|.txt|Winrar Dosyaalar�(*.rar)|.rar|T�m Dosyalar(*.*)|*.*
            //bu ofd nin filtre b�l�m�ne yaz�l�rsa sadece bu dosyalar� ekleyebiliyor kullan�c�.
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            StreamReader strRead = new StreamReader(txtFilePath.Text);

            string str = strRead.ReadToEnd();

            rtxtFileContent.Text = str;

            strRead.Close(); // dosyayla baglant�y� kesip ba�ka bir se�imde hata almamak i�in

        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            StreamWriter strWrite = new StreamWriter(txtFilePath.Text);
            strWrite.Write(rtxtFileContent.Text);
            strWrite.Close();
            rtxtFileContent.Clear();
        }

        // File Stream
        //FileStream s�n�f� ile diskte bulunan bir dosyaya ula��m sa�layabiliriz.
        //StreamWriter ve StreamReader ile a��lan bir dosya �zerinde yazma ve okuma i�lemleri yap�labilir
        /* dosya uzer�nde met�n tabanl� veya byte table tabanl� �slemler yap�la�bl�r
         * Read() ya da ReadByte() metotlar� byte duey�nde ver� okumam�z� saglayan metodlard�r.
         * ReadByte() okuma yapmaz ile -1 d�ndurur.
         * 
         */
    }
}