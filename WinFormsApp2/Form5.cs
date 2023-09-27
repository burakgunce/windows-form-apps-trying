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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        double katsayi1, katsayi2, katsayi3;
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                katsayi1 = 2;
            }
            else
            {
                katsayi1 = 1;
            }

            if (radioButton3.Checked)
            {
                katsayi2 = 4;
            }
            else
            {
                katsayi2 = 1;
            }

            if (radioButton5.Checked)
            {
                katsayi3 = 1;
            }
            else if (radioButton6.Checked)
            {
                katsayi3 = 5;
            }
            else if (radioButton7.Checked)
            {
                katsayi3 = 6;
            }

            else
            {
                katsayi1 = 7;
            }

            double hesapla = int.Parse(textBox1.Text) * katsayi1 * katsayi2 * katsayi3;
            label4.Text = hesapla.ToString();


        }
    }
}
