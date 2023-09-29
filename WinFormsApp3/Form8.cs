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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        public void VerileriGoster(string adSoyad, double ortalama, string sonuc)
        {
            label4.Text = adSoyad;
            label5.Text = ortalama.ToString();
            label6.Text = sonuc;
        }
    }
}
