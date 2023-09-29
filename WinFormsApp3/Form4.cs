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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        List<string> adSoyadList = new List<string>();
        List<string> tcNoList = new List<string>();
        List<string> dogumYeriList = new List<string>();
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item.GetType() == typeof(TextBox))
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BosAlanVarMi())
            {
                MessageBox.Show("lütfen boş alan bırakmayınız");
            }
            else
            {
                adSoyadList.Add(textBox1.Text);
                tcNoList.Add(textBox2.Text);
                dogumYeriList.Add(textBox3.Text);

                MessageBox.Show("Ekleme işlemi başarılı");
            }
        }

        private bool BosAlanVarMi()
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    if (txt.Text == "")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.VerileriGonder(adSoyadList,tcNoList,dogumYeriList);
            frm.Show();
        }
    }
}
