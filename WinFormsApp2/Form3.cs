using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Generic List oluşturma
            List<int> sayilar = new List<int>();
            sayilar.Add(1);
            sayilar.Add(2);
            sayilar.Add(3);
            // tanımlamada olusturulan veri tipine uygun elemanlar eklenmeli
            MessageBox.Show("elemanlar list e eklendi eleman sayısı = " + sayilar.Count);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("trabzon");
            sehirler.Add("elazığ");
            sehirler.Add("sivas");
            sehirler.Add("sakarya");

            foreach (string sehir in sehirler)
            {
                MessageBox.Show(sehir);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("trabzon");
            sehirler.Add("elazığ");
            sehirler.Add("sivas");
            sehirler.Add("sakarya");

            sehirler.Sort();
            foreach (string sehir in sehirler)
            {
                MessageBox.Show(sehir);
            }
        }
    }
}
