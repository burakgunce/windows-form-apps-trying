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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        string kullaniciAdi = "edilee";
        string sifre = "123";

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == kullaniciAdi && textBox2.Text == sifre)
            {
                Form6 form6 = new Form6();
                form6.KullaniciAdiAl(kullaniciAdi);
                this.Hide();
                form6.ShowDialog();
                this.Show();
            }
        }
    }
}
