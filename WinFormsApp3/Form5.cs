using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public void VerileriGonder(List<string> adSoyadList, List<string> tcNoList, List<string> dogumYeriList)
        {
            string personelBilgi = string.Empty;
            int sayac = 0;
            foreach (string personel in adSoyadList)
            {
                personelBilgi = $"{personel} --- {tcNoList[sayac]} --- {dogumYeriList[sayac]}";
                listBox1.Items.Add(personelBilgi);
                sayac++;
            }
        }
    }
}
