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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        List<string> ad = new List<string>();
        List<string> soyad = new List<string>();
        List<string> yas = new List<string>();
        List<string> cinsiyet = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            string adText = textBox1.Text;
            string soyadText = textBox2.Text;
            string yasText = textBox3.Text;
            string cins = radioButton1.Checked ? "Kadın" : "Erkek";

            string personInfo = adText + " " + soyadText + " - " + cins + " - " + yasText;

            ad.Add(adText);
            soyad.Add(soyadText);
            yas.Add(yasText);
            cinsiyet.Add(cins);

            listBox1.Items.Add(personInfo);
            //normally we dont need lists
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            form10.ListeVerileriniAyarla(listBox1.Items.Cast<string>().ToList());
            form10.Show();

        }
    }
}
