using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        List<string> ogrenciListesi = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciListesi.Add(textBox1.Text);
            textBox1.Clear();
        }

        private void öğrenciListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(ogrenciListesi);
            form3.ShowDialog();
        }
    }
}
