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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int rastgeleSayi;

        private void Form3_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 60;
            button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            rastgeleSayi = rnd.Next(1, 101);
            progressBar1.Value = progressBar1.Maximum;
            button2.Enabled = true;
            label3.Text = "";
            label2.Text = string.Empty;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value--;
            button2.Text = "Tahmin Et (" + progressBar1.Value + ")";
            switch (progressBar1.Value)
            {
                case 50:
                    label3.Text = "galiba kaybedeceksin";
                    break;
                case 30:
                    label3.Text = "sen kaybetmek ıcın yarısıyorsun";
                    break;
                case 20:
                    label3.Text = "bu ısı yapamıyorsun bırak";
                    break;
                case 0:
                    label3.Text = "tekrar dene ancak gene yapamayacaksın";
                    timer1.Stop();
                    break;


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            try 
            { 
                sayi = int.Parse(textBox1.Text.Trim()); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sayı Giriniz");
            }
            label2.Text = sayi.ToString();
            if (sayi < rastgeleSayi)
            {
                label2.Text += "kucuk sayi girdin";
            }
            else if (sayi > rastgeleSayi)
            {
                label2.Text += "buyuk sayi girdin";
            }
            else 
            {
                label2.Text += "KAZANDIN";
                int kacSaniyedeBildi = Math.Abs(progressBar1.Value - 60);

                if (kacSaniyedeBildi > 50 && kacSaniyedeBildi <= 60)
                {
                    label3.Text = "Son saniyede bildin";
                }
                //buna benzer kosullar buraya gelebilir
                timer1.Stop();
                button2.Enabled = false;
            }
            textBox1.Clear();

        }
    }
}
