using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnDrive_Click(object sender, EventArgs e)
        {
            DriveInfo di = new DriveInfo(@"C:\");

            string driveInfo = string.Empty;
            driveInfo = $"Sürücü Adı : {di.Name}\n Sürücü Ön Adı : {di.VolumeLabel}\n" +
                $"Toplam Boyut : {di.TotalSize}\n Boş Alan Boyutu : {di.TotalFreeSpace}" +
                $"Kullanılabilir Boş Alan : {di.AvailableFreeSpace}";
            MessageBox.Show(driveInfo);
        }

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            DirectoryInfo dirInfo = new DirectoryInfo("C:\\FileStream");

            string directoryInfo = string.Empty;
            directoryInfo = $"Klasör Yolu : {dirInfo.FullName}\n Klasör Adı : {dirInfo.Name}\n" +
                $"Bir Üst Klasör Adı : {dirInfo.Parent}\n Dosya Türü : {dirInfo.Attributes}\n" +
                $"Son Değiştirilme Tarihi : {dirInfo.LastWriteTime}";
            MessageBox.Show(directoryInfo);
        }

        private void btnKlasorIslemleri_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("C:\\FileStream"))
            {
                Directory.Delete("C:\\FileStream");
            }

            Directory.CreateDirectory("C:\\FileStream");
        }

        private void btnDirectories_Click(object sender, EventArgs e)
        {
            string[] directories =
            Directory.GetDirectories("C:\\Windows\\System32");
            lstDirectory.Items.Clear();
            foreach (string directory in directories)
            {
                lstDirectory.Items.Add(directory);
            }
        }

        private void btnFiles_Click(object sender, EventArgs e)
        {
            string[] files =
            Directory.GetFiles("C:\\Windows\\System32");


            foreach (string file in files)
            {
                string fileInfo = string.Empty;
                FileInfo fi = new FileInfo("file");
                fileInfo = $"{fi.FullName} - {fi.Name} - {fi.Length} byte  - {fi.CreationTime}";
                lstFiles.Items.Add(fileInfo);
            }
        }

        private void btnDosyaKopyala_Click(object sender, EventArgs e)
        {
            string sourceFile = "C:\\FileStream";
            string destinationFile = "C:\\FileStream2";
            File.Move(sourceFile, destinationFile);
        }

        private void btnKlasorKopyala_Click(object sender, EventArgs e)
        {
            string sourceDir = "C:\\FileStream";
            string destinationDir = "C:\\FileStream2";
            Directory.Move(sourceDir,destinationDir);
        }

        //MEMORY STREAM BAK
    }
}
