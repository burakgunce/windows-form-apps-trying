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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double ortalama = (int.Parse(textBox2.Text) + int.Parse(textBox3.Text) + int.Parse(textBox3.Text))/3;
            string sonuc;
            if (ortalama >= 50)
            {
                sonuc = "gecti";
            }
            else
            {
                sonuc = "kaldı";
            }
            Form8 frm = new Form8();
            frm.VerileriGoster(textBox1.Text,ortalama,sonuc);
            frm.Show();
            
        }
    }
}
