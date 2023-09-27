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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        List<int> ints = new List<int>();
        private void button1_Click(object sender, EventArgs e)
        {

            ints.Add((int)numericUpDown1.Value);
            numericUpDown1.ResetText();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"en buyuk {ints.Max()} en kucuk = {ints.Min()}");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            numericUpDown1.ResetText();
        }
    }
}
